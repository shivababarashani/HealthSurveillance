using System;
using System.Collections.Generic;
using System.Text;

using System.ComponentModel.DataAnnotations.Schema;
using HealthSurveillance.Domain.Entities.Common;

namespace HealthSurveillance.Domain.Entities
{
    public class Field : GenericEntity
    {
        public string Name { get; set; }

        public Guid FieldTypeId { get; set; }

        [ForeignKey("FieldTypeId")]
        public virtual FieldType FieldType { get; set; }

        public virtual ICollection<FieldOption> FieldOptions { get; set; }

        public virtual ICollection<FieldGroup> FieldGroups { get; set; }
    }
}
