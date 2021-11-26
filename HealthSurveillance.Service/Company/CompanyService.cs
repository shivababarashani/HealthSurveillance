using AutoMapper;
using AutoMapper.QueryableExtensions;
using HealthSurveillance.Domain.Entities.Common.Contracts;
using HealthSurveillance.Domain.Entities.Company.ViewModel;

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using HealthSurveillance.Domain.Entities.Company.Dto;
using System.IO;
using Microsoft.AspNetCore.Http;
using HealthSurveillance.Service.Common;
using Microsoft.AspNetCore.Hosting;

namespace HealthSurveillance.Service.Company
{
    public class CompanyService
    {
        private readonly IRepository<Domain.Entities.Company.DataModels.Company> _repository;
        private readonly IMapper _mapper;
        private readonly IHostingEnvironment _enviroment;
        public CompanyService(IRepository<Domain.Entities.Company.DataModels.Company> repository, IMapper mapper, IHostingEnvironment environment)
        {
            _repository = repository;
            _mapper = mapper;
            _enviroment = environment;
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
            FileManager fileManager = new FileManager(_enviroment);
            await fileManager.InsertFiles(request.ImageFile, "Files/Images");
            var model = new Domain.Entities.Company.DataModels.Company();
            _mapper.Map(request, model);
            await _repository.AddAsync(model, cancellationToken);
        }

       
    }
}
