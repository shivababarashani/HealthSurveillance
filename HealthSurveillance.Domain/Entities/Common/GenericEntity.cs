using System;
using System.Collections.Generic;
using System.Text;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HealthSurveillance.Domain.Entities.Common
{
    public interface IEntity
    {
    }

    public interface IEntity<TKey> : IEntity
    {
        TKey Id { get; set; }
    }

    public abstract class GenericEntity<TKey> : IEntity<TKey>
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public TKey Id { get; set; }
        public DateTime CreateOn { get; set; }

        public bool IsActive { get; set; }

        public DateTime LastModifyOn { get; set; }
    }

    public abstract class GenericEntity : GenericEntity<Guid>
    {
    }
   
    //public class GenericEntity : IEntity
    //{
    //    [Key]
    //    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    //    public Guid Id { get; set; }

    //    public DateTime CreateOn { get; set; }

    //    public bool IsActive { get; set; }

    //    public DateTime LastModifyOn { get; set; }
    //}
}
