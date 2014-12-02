namespace FoodOrderSystem.Data.Models
{
    using System;
    using System.Linq;
    using FoodOrderSystem.Data.Contracts.Models;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class EateryCategory : AuditInfo, IDeletableEntity
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        [Index]
        public bool IsDeleted {get;set;}
       
        public DateTime? DeletedOn {get;set;}
    }
}
