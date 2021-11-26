using System;
using System.Collections.Generic;
using System.Text;

using System.ComponentModel.DataAnnotations.Schema;
using HealthSurveillance.Domain.Entities.Common;

namespace HealthSurveillance.Domain.Entities
{
    public class Group : GenericEntity
    {
        [ForeignKey("Parent")]
        public Guid? ParentId { get; set; }

        public string Name { get; set; }

        public int ViewOrder { get; set; }

        public virtual Group Parent { get; set; }

        public virtual ICollection<FieldGroup> FieldGroups { get; set; }
    }
}
