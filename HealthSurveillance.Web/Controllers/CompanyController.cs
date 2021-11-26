using HealthSurveillance.Domain.Entities.Company.Dto;
using HealthSurveillance.Domain.Entities.Company.ViewModel;
using HealthSurveillance.Service.Company;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace HealthSurveillance.Web.Controllers
{
    public class CompanyController : Controller
    {
        private readonly CompanyService _companyService;
        public CompanyController(CompanyService companyService)
        {
            _companyService = companyService;
        }
        public IActionResult Index()
        {
            return View();
        }
        //[Authorize(Roles = "Admin")]
        public virtual async Task<ActionResult<List<CompanyViewModel>>> Get(CancellationToken cancellationToken)
        {
           return await _companyService.Get(cancellationToken);
        }
        [HttpGet("{id:guid}")]
        public async Task<CompanyViewModel> Get(Guid id, CancellationToken cancellationToken)
        {
            return await _companyService.Get(id,cancellationToken);
        }
        [HttpPost]
        public async Task Create(CreateCompanyDto dto, CancellationToken cancellationToken)
        {
             await _companyService.Create(dto, cancellationToken);
        }

    }
}
