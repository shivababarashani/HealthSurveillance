using System;
using System.Collections.Generic;
using System.Text;

using System.ComponentModel.DataAnnotations.Schema;
using HealthSurveillance.Domain.Entities.Common;

namespace HealthSurveillance.Domain.Entities.Company.DataModels
{
    public class Company : GenericEntity
    {
        public string Name { get; set; }

        public string Address { get; set; }

        public string Tel { get; set; }

        public string FullName { get; set; }

        public string Logo { get; set; }

        public string Tag { get; set; }

        public string Desc { get; set; }
    }
}
