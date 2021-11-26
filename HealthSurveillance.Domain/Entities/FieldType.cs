using HealthSurveillance.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace HealthSurveillance.Domain.Entities
{
    public class FieldType : GenericEntity
    {
        public string Name { get; set; }

        public int Type { get; set; }

        public virtual ICollection<Field> Fields { get; set; }
    }
}
