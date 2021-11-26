using System;
using System.Collections.Generic;
using System.Text;

using System.ComponentModel.DataAnnotations.Schema;
using HealthSurveillance.Domain.Entities.Common;

namespace HealthSurveillance.Domain.Entities
{
    public class FieldGroup : GenericEntity
    {
        public Guid GroupId { get; set; }

        public Guid FieldId { get; set; }

        public int ViewOrder { get; set; }

        [ForeignKey("GroupId")]
        public virtual Group Group { get; set; }

        [ForeignKey("FieldId")]
        public virtual Field Field { get; set; }

        public virtual ICollection<UserField> UserFields { get; set; }
    }
}
