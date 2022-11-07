using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore.Query.Internal;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Data.Infrastructure
{
    public static class BulkExtensions
    {
        /// <summary>
        /// Insert a list of entities using MYSQL bulk insert 
        /// </summary>
        /// <typeparam name="T">Type of entity (class)</typeparam>
        /// <param name="dataContext">Entity fromework database context instance</param>
        /// <param name="entities">list of entities to be inserted</param>
        public static void BulkInsert<T>(this DbContext dataContext, List<T> entities)
        {
            //if entities list is not empty
            if (entities != null && entities.Count > 0)
            {
                DataTable dataTable = new DataTable();
                //convert list to datatable and remove unwanted properties
                dataTable = ToDataTable(entities, dataContext);
                var lines = new List<string>();
                //retrieve columns names
                string[] columnNames = dataTable.Columns
                    .Cast<DataColumn>()
                    .Select(column => column.ColumnName)
                    .ToArray();
                //construct column names part in the query (`id`,`name`)
                string header = "(" + string.Join(",", columnNames.Select(name => "`" + name + "`")) + ")";
                //construct row part in the query (5,'Yasser')
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    string row = "(" + string.Join(",", dataTable.Rows[i].ItemArray) + ")";
                    lines.Add(row);
                }
                //group all data rows lines with comma seperated
                string rows = string.Join(",", lines.Select(name => name));
                //get entity table name
                var mapping = dataContext.Model.FindEntityType(typeof(T));
                //construct insert statement
                string Query = "INSERT INTO " + mapping.GetTableName() + " " + header + " VALUES " + rows + ";";
                //construct get last inserted id statement
                Query = Query + "SELECT LAST_INSERT_ID();";
                //execute the query
                using (var command = dataContext.Database.GetDbConnection().CreateCommand())
                {
                    command.CommandText = Query;
                    dataContext.Database.OpenConnection();
                    using (DbDataReader result = command.ExecuteReader())
                    {
                        bool isRead = result.Read();
                        if (isRead)
                        {
                            //get primary key
                            string PKColumn = mapping.FindPrimaryKey().Properties[0].Name;
                            PropertyInfo prop = typeof(T).GetProperty(PKColumn, BindingFlags.Public | BindingFlags.Instance);
                            //check if not guid
                            if (prop.PropertyType.Name != "Guid")
                            {
                                int lastInsertedID = Convert.ToInt32(result.GetValue(0));
                                if (lastInsertedID > 0)
                                {
                                    //update entities with newly created ids
                                    for (int i = 0; i < entities.Count; i++)
                                    {
                                        prop.SetValue(entities[i], lastInsertedID + i);

                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        /// <summary>
        /// update a list of entities using MYSQL bulk update 
        /// </summary>
        /// <typeparam name="T">Type of entity (class)</typeparam>
        /// <param name="dataContext">Entity fromework database context instance</param>
        /// <param name="entities">list of entities to be updated</param>
        public static void BulkUpdate<T>(this DbContext dataContext, List<T> entities)
        {
            if (entities != null && entities.Count > 0)
            {
                DataTable dataTable = new DataTable();
                dataTable = ToDataTable(entities, dataContext, true);
                var lines = new List<string>();

                string[] columnNames = dataTable.Columns
                    .Cast<DataColumn>()
                    .Select(column => column.ColumnName)
                    .ToArray();

                string header = "(" + string.Join(",", columnNames.Select(name => "`" + name + "`")) + ")";
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    string row = "(" + string.Join(",", dataTable.Rows[i].ItemArray) + ")";
                    lines.Add(row);
                }
                string rows = string.Join(",", lines.Select(name => name));
                var mapping = dataContext.Model.FindEntityType(typeof(T));
                string Query = "INSERT INTO " + mapping.GetTableName() + " " + header + " VALUES " + rows;
                string DUPLICATE_KEY_UPDATE = " ON DUPLICATE KEY UPDATE " + string.Join(",", columnNames.Select(name => "`" + name + "` = VALUES(`" + name + "`)"));
                //execute the query
                using (var command = dataContext.Database.GetDbConnection().CreateCommand())
                {
                    command.CommandText = Query + DUPLICATE_KEY_UPDATE;
                    dataContext.Database.OpenConnection();
                    using (DbDataReader result = command.ExecuteReader())
                    {
                        bool isRead = result.Read();
                    }
                }


            }
        }

        /// <summary>
        /// convert list of items to a datatable
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="items"></param>
        /// <param name="dataContext"></param>
        /// <param name="isUpdate"></param>
        /// <returns></returns>
        public static DataTable ToDataTable<T>(List<T> items, DbContext dataContext, bool isUpdate = false)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);
            //Get all the properties
            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            var mapping = dataContext.Model.FindEntityType(typeof(T));
            string PKColumn = mapping.FindPrimaryKey().Properties[0].Name;

            foreach (PropertyInfo prop in Props)
            {

                if ((isUpdate || prop.Name != PKColumn || prop.PropertyType.Name == "Guid") && (prop.PropertyType.IsValueType || prop.PropertyType.Name == "String"))
                {
                    //Setting column names as Property names
                    dataTable.Columns.Add(prop.Name);
                }
            }
            foreach (T item in items)
            {
                var values = new object[dataTable.Columns.Count];
                for (int i = 0; i < dataTable.Columns.Count; i++)
                {
                    //inserting property values to datatable rows
                    PropertyInfo p = Props.FirstOrDefault(p => p.Name == dataTable.Columns[i].ColumnName);
                    var value = p.GetValue(item);
                    if (p.PropertyType == typeof(int) || p.PropertyType == typeof(int?))
                    {
                        values[i] = value == null ? "NULL" : (value + "").Replace(",", ".");
                    }
                    else if (p.PropertyType == typeof(bool) || p.PropertyType == typeof(bool?))
                    {
                        values[i] = value == null ? "NULL" : value.ToString().ToLower() == "false" ? "0" : "1";
                    }
                    else if (p.PropertyType == typeof(double) || p.PropertyType == typeof(double?))
                    {
                        values[i] = value == null ? "NULL" : (value + "").Replace(",", ".");
                    }
                    else if (p.PropertyType == typeof(decimal) || p.PropertyType == typeof(decimal?))
                    {
                        values[i] = value == null ? "NULL" : (value + "").Replace(",", ".");
                    }
                    else if (p.PropertyType == typeof(DateTime) || p.PropertyType == typeof(DateTime?))
                    {
                        if (value == null)
                        {
                            values[i] = "NULL";
                        }
                        else
                        {
                            values[i] = "'" + string.Format("{0:yyyy-MM-dd hh:mm:ss}", Convert.ToDateTime(value)) + "'";

                        }
                    }
                    else
                    {
                        values[i] = value == null ? "NULL" : "'" + MySQLEscape(value + "") + "'";
                    }
                }
                dataTable.Rows.Add(values);
            }
            //put a breakpoint here and check datatable
            return dataTable;

        }
        public static string MySQLEscape(string str)
        {
            string escapeVaue = System.Text.RegularExpressions.Regex.Escape(str);
            string finalAnswer = Regex.Replace(escapeVaue, @"[\@\'\x00'""\b\n\r\t\cZ%]",
                delegate (Match match)
                {
                    string v = match.Value;
                    switch (v)
                    {
                        case "\x00":            // ASCII NUL (0x00) character
                            return "\\0";
                        case "\b":              // BACKSPACE character
                            return "\\b";
                        case "\n":              // NEWLINE (linefeed) character
                            return "\\n";
                        case "\r":              // CARRIAGE RETURN character
                            return "\\r";
                        case "\t":              // TAB
                            return "\\t";
                        case "\u001A":          // Ctrl-Z
                            return "\\Z";
                        default:
                            return "\\" + v;
                    }
                });

            return finalAnswer;
        }
        public static DbContext GetDbContext(IQueryable query)
        {
            var bindingFlags = BindingFlags.NonPublic | BindingFlags.Instance;
            var queryCompiler = typeof(EntityQueryProvider).GetField("_queryCompiler", bindingFlags).GetValue(query.Provider);
            var queryContextFactory = queryCompiler.GetType().GetField("_queryContextFactory", bindingFlags).GetValue(queryCompiler);

            var dependencies = typeof(RelationalQueryContextFactory).GetField("_dependencies", bindingFlags).GetValue(queryContextFactory);
            var queryContextDependencies = typeof(DbContext).Assembly.GetType(typeof(QueryContextDependencies).FullName);
            var stateManagerProperty = queryContextDependencies.GetProperty("StateManager", bindingFlags | BindingFlags.Public).GetValue(dependencies);
            var stateManager = (IStateManager)stateManagerProperty;

            #pragma warning disable EF1001 // Internal EF Core API usage.
            return stateManager.Context;
            #pragma warning restore EF1001 // Internal EF Core API usage.
        }
        public static string ToSql<TEntity>(this IQueryable<TEntity> query) where TEntity : class
        {
            var enumerator = query.Provider.Execute<IEnumerable<TEntity>>(query.Expression).GetEnumerator();
            var relationalCommandCache = enumerator.Private("_relationalCommandCache");
            var selectExpression = relationalCommandCache.Private<SelectExpression>("_selectExpression");
            var factory = relationalCommandCache.Private<IQuerySqlGeneratorFactory>("_querySqlGeneratorFactory");

            var sqlGenerator = factory.Create();
            var command = sqlGenerator.GetCommand(selectExpression);

            string sql = command.CommandText;
            return sql;
        }
        private static object Private(this object obj, string privateField) => obj?.GetType().GetField(privateField, BindingFlags.Instance | BindingFlags.NonPublic)?.GetValue(obj);
        private static T Private<T>(this object obj, string privateField) => (T)obj?.GetType().GetField(privateField, BindingFlags.Instance | BindingFlags.NonPublic)?.GetValue(obj);
    }
}
