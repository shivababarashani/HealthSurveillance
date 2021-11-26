using HealthSurveillance.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace HealthSurveillance.Domain.Entities
{
    public class Special : GenericEntity
    {
        public string Name { get; set; }

        public string Logo { get; set; }

        public string Desc { get; set; }
    }
}
