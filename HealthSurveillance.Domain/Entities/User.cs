using HealthSurveillance.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace HealthSurveillance.Domain.Entities
{
    public class User : GenericEntity
    {
        public string Username { get; set; }

        public string Password { get; set; }

        public string Code { get; set; }

        public virtual ICollection<UserField> UserFields { get; set; }
    }
}
