using Helpers;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        DBEntities dbContext;
        private readonly IConfiguration Config;
        private readonly SecurityHelper _security;

        public DbFactory(IConfiguration configuration,SecurityHelper security)
        {
            Config = configuration;
            _security = security;
        }
        public DBEntities Init()
        {
            return dbContext ?? (dbContext = CreateDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }

        public DBEntities CreateDbContext()
        {
            var optionsBuilder = new DbContextOptionsBuilder<DBEntities>();

            optionsBuilder.UseMySql(Config.GetConnectionString("DefaultConnection"));
            // uncomment this line incase use sql server and disable table locking
            //.AddInterceptors(new WithNoLockInterceptor());
            return new DBEntities(optionsBuilder.Options);
        }
    }
}
