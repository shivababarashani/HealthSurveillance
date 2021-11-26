using Data.Repositories;
using HealthSurveillance.Domain.Entities.Company;
using HealthSurveillance.Domain.Entities.Company.Contracts;
using HealthSurveillance.Domain.Entities.Company.ViewModel;
using HealthSurveillance.Persistence.Db;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HealthSurveillance.Persistence.Company
{
   public class CompanyRepository : Repository<Domain.Entities.Company.DataModels.Company>, ICompanyRepository
    {
        public CompanyRepository(HealthSurveillanceDbContext dbContext)
         : base(dbContext)
        {
        }
        public async Task AddAsync(Domain.Entities.Company.DataModels.Company company, CancellationToken cancellationToken)
        {
            await base.AddAsync(company, cancellationToken);
        }
    }
}
