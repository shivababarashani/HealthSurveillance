using Data.Repositories;
using HealthSurveillance.Domain.Entities.Common.Contracts;
using HealthSurveillance.Domain.Entities.Company.Contracts;
using HealthSurveillance.Persistence.Company;
using HealthSurveillance.Service.Company;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace HealthSurveillance.Web.Configuration
{
    public static class IocExtension
    {
        public static IServiceCollection AddCustomServices(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddTransient(typeof(IRepository<>), typeof(Repository<>));
            #region Company
            services.AddScoped<ICompanyRepository, CompanyRepository>();
            services.AddScoped<CompanyService>();
            #endregion

            return services;
        }
    }
}
