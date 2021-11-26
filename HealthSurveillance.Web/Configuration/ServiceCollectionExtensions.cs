using AutoMapper;
using HealthSurveillance.Persistence.Db;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthSurveillance.Web.Configuration
{
    public static class ServiceCollectionExtensions
    {
        public static void AddDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<HealthSurveillanceDbContext>(options =>
            {
                options
                    .UseSqlServer(configuration.GetConnectionString("SqlServer"));
                //Tips
                //Automatic client evaluation is no longer supported. This event is no longer generated.
                //This line is no longer needed.
                //.ConfigureWarnings(warning => warning.Throw(RelationalEventId.QueryClientEvaluationWarning));
            });
        }
        public static void AddAuthoMapper(this IServiceCollection services, IConfiguration configuration)
        {
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new EntityMapping());
            });
            var mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);
        }

        //public static void AddElmahCore(this IServiceCollection services, IConfiguration configuration, SiteSettings siteSetting)
        //{
        //    services.AddElmah<SqlErrorLog>(options =>
        //    {
        //        options.Path = siteSetting.ElmahPath;
        //        options.ConnectionString = configuration.GetConnectionString("Elmah");
        //        //options.CheckPermissionAction = httpContext => httpContext.User.Identity.IsAuthenticated;
        //    });
        //}


    }
}
