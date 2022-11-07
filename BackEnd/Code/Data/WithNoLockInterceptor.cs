using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Data.Common;
using System.Text.RegularExpressions;


namespace Infrastructure.Data
{
    public class WithNoLockInterceptor : DbCommandInterceptor
    {
        //private static readonly Regex TableAliasRegex = new Regex("(?<tableAlias>AS \\[Extent\\d+\\](?! WITH \\(NOLOCK\\)))", RegexOptions.IgnoreCase | RegexOptions.Multiline);

        private static readonly Regex _tableAliasRegex =
        new Regex(@"(?<tableAlias>FROM +(\[.*\]\.)?(\[.*\]) AS (\[.*\])(?! WITH \(NOLOCK\)))",
            RegexOptions.Multiline |
            RegexOptions.IgnoreCase |
            RegexOptions.Compiled);

        [ThreadStatic]
        public static string CommandText;

        public override InterceptionResult<object> ScalarExecuting(DbCommand command, CommandEventData eventData, InterceptionResult<object> result)
        {
            //command.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED " + CommandText; 
            command.CommandText = WithNoLockInterceptor._tableAliasRegex.Replace(command.CommandText, "${tableAlias} WITH (NOLOCK)");
            if (!command.CommandText.Contains("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED"))
            {
                command.CommandText = command.CommandText.Replace(command.CommandText, "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED;" + command.CommandText);
            }
            WithNoLockInterceptor.CommandText = command.CommandText;
            return result;
        }

        public override InterceptionResult<DbDataReader> ReaderExecuting(DbCommand command, CommandEventData eventData, InterceptionResult<DbDataReader> result)
        {
            //command.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED " + CommandText;
            command.CommandText = WithNoLockInterceptor._tableAliasRegex.Replace(command.CommandText, "${tableAlias} WITH (NOLOCK)");
            if (!command.CommandText.Contains("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED"))
            {
                command.CommandText = command.CommandText.Replace(command.CommandText, "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED;" + command.CommandText);
            }
            WithNoLockInterceptor.CommandText = command.CommandText;
            return result;
        }
    }
}
