using System;
using System.Text;
using Data;
using Data.Infrastructure;
using Data.Repositories;
//using Data.Repositories.Contracts;
using Helpers;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Notifications.Helpers;
using Services;
//using Services.Contracts;
//using Services.Mappers;
//using Services.Services;
using WebAPI.ActionFilters;
using WebAPI.Common;

namespace WebAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration, IWebHostEnvironment env)
        {
            Configuration = configuration;
            WebHostEnvironment = env;
        }

        public IConfiguration Configuration { get; }
        public IWebHostEnvironment WebHostEnvironment { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddRazorPages(); 

            //configure Security Helper
            services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddTransient<SecurityHelper, SecurityHelper>();

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                    .AddJwtBearer(jwtBearerOptions =>
                    {
                        jwtBearerOptions.TokenValidationParameters = new TokenValidationParameters()
                        {
                            ValidateActor = true,
                            ValidateAudience = true,
                            ValidateLifetime = true,
                            ValidateIssuerSigningKey = true,
                            ValidIssuer = Configuration["Issuer"],
                            ValidAudience = Configuration["Audience"],
                            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["SigningKey"]))
                        };
                    });

            services.AddControllers()
                .AddNewtonsoftJson(options => {
                    options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
                    options.SerializerSettings.ContractResolver = new DefaultContractResolver();
                    options.SerializerSettings.NullValueHandling = NullValueHandling.Ignore;
                }).AddJsonOptions(opt => opt.JsonSerializerOptions.PropertyNamingPolicy = null);
            //services.AddSwaggerGen();
            services.AddSwaggerDocument(o => o.Title = "API");
            //Add Cross Origins Policy
            services.AddCors(options =>
            {
                options.AddPolicy("AllowAllOrigins",
                    policy => policy
                        .AllowAnyOrigin()
                        .AllowAnyHeader()
                        .AllowAnyMethod());
            });
            //to be used in migration only
            services.AddDbContextPool<DBEntities>( // replace "YourDbContext" with the class name of your DbContext
                options => options.UseMySql(Configuration.GetConnectionString("DefaultConnection")
            ));
                        
            //General
            services.AddScoped<DbContext, DBEntities>();
            services.AddScoped<IDbFactory, DbFactory>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            //Mapper
            services.AddScoped<IProductMapper,ProductMapper>();
            services.AddScoped<ICategoryMapper, CategoryMapper>();
            services.AddScoped<ISupplierMapper, SupplierMapper>();
            services.AddScoped<ICustomerMapper, CustomerMapper>();
            services.AddScoped<IPurchaseOrderMapper, PurchaseOrderMapper>();
            services.AddScoped<IBillMapper, BillMapper>();
            services.AddScoped<IItemMapper, ItemMapper>();
            services.AddScoped<ISaleMapper, SaleMapper>();



            RazorBootStrapper.Init(WebHostEnvironment);
            ConfigureService.RegisterRepositories(services);
            ConfigureService.RegisterServices(services);

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IServiceProvider serviceProvider)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            //app.UseSwagger();

            app.UseCustomExceptionHandler();

            //app.UseSwaggerUI(c =>
            //{
            //    string swaggerJsonBasePath = string.IsNullOrWhiteSpace(c.RoutePrefix) ? "." : "..";
            //    c.SwaggerEndpoint($"{swaggerJsonBasePath}/swagger/v1/swagger.json", "My API");
            //});
            app.UseRouting();
            // Add your NSwag Extension here  
            app.UseOpenApi();
            app.UseSwaggerUi3();
            app.UseCors("AllowAllOrigins");

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseStaticFiles();

            ConfigurationHelper.Configure(serviceProvider.GetService<IConfiguration>());
            HostEnvironmentHelper.Configure(serviceProvider.GetService<IHostEnvironment>());

        }
    }
}
