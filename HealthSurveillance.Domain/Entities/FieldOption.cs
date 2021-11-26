using System;
using System.Collections.Generic;
using System.Text;

using System.ComponentModel.DataAnnotations.Schema;
using HealthSurveillance.Domain.Entities.Common;

namespace HealthSurveillance.Domain.Entities
{
    public class FieldOption : GenericEntity
    {
        public string Name { get; set; }

        public int ViewOrder { get; set; }
        
        public Guid FieldId { get; set; }

        [ForeignKey("FieldId")]
        public virtual Field Field { get; set; }

        public virtual ICollection<UserField> UserFields { get; set; }
    }
}
