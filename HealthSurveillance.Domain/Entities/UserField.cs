using System;
using System.Collections.Generic;
using System.Text;

using System.ComponentModel.DataAnnotations.Schema;
using HealthSurveillance.Domain.Entities.Common;

namespace HealthSurveillance.Domain.Entities
{
    public class UserField : GenericEntity
    {
        public Guid UserId { get; set; }

        public Guid FieldGroupId { get; set; }

        public Guid? FieldOptionId { get; set; }

        public string Value { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; }

        [ForeignKey("FieldGroupId")]
        public virtual FieldGroup FieldGroup { get; set; }

        [ForeignKey("FieldOptionId")]
        public virtual FieldOption FieldOption { get; set; }
    }
}
