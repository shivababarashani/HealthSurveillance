using AutoMapper;
using AutoMapper.QueryableExtensions;
using HealthSurveillance.Domain.Entities.Common.Contracts;
using HealthSurveillance.Domain.Entities.Company.ViewModel;
using HealthSurveillance.Domain.Entities.Company;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using HealthSurveillance.Domain.Entities.Company.Dto;

namespace HealthSurveillance.Service.Company
{
    public class CompanyService
    {
        private readonly IRepository<Domain.Entities.Company.DataModels.Company> _repository;
        private readonly IMapper _mapper;

        public CompanyService(IRepository<Domain.Entities.Company.DataModels.Company> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<List<CompanyViewModel>> Get(CancellationToken cancellationToken)
        {
            return await _repository.TableNoTracking.ProjectTo<CompanyViewModel>(_mapper.ConfigurationProvider)
               .ToListAsync(cancellationToken);
        }
        public async Task<CompanyViewModel> Get(Guid id, CancellationToken cancellationToken)
        {
            var companymodel = new CompanyViewModel();
            var entity = await _repository.TableNoTracking
                 .SingleOrDefaultAsync(p => p.Id == id, cancellationToken);
            return _mapper.Map(entity, companymodel);
        }
        public async Task Create(CreateCompanyDto request, CancellationToken cancellationToken)
        {
            var model = new Domain.Entities.Company.DataModels.Company();
            _mapper.Map(request, model);
            await _repository.AddAsync(model, cancellationToken);
        }
    }
}
