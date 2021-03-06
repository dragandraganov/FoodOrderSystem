namespace FoodOrderSystem.Data.Models
{
    using System;
    using FoodOrderSystem.Data.Contracts.Models;
    using System.ComponentModel.DataAnnotations;

    public class Town : IAuditInfo, IDeletableEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public DateTime CreatedOn { get; set; }

        public bool PreserveCreatedOn { get; set; }
      
        public DateTime? ModifiedOn { get; set; }
      
        public bool IsDeleted { get; set; }
       
        public DateTime? DeletedOn { get; set; }
       
    }
}