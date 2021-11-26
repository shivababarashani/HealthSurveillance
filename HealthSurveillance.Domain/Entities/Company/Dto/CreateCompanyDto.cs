using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthSurveillance.Domain.Entities.Company.Dto
{
    public class CreateCompanyDto
    {
        public string Name { get; set; }

        public string Address { get; set; }

        public string Tel { get; set; }

        public string FullName { get; set; }

        public IFormFile Logo { get; set; }

        public string Desc { get; set; }
    }
}
