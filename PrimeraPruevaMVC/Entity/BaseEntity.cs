using System;
namespace PrimeraPruevaMVC.Entity
{
    public class BaseEntity
    {
        public BaseEntity()
        {
        }

        public Guid Id {get; set;}

        public DateTime CreationDate {get; set;}

        public DateTime? UpdateDate {get; set;}

    }
}