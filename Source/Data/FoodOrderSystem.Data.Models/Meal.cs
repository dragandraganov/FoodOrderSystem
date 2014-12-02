namespace FoodOrderSystem.Data.Models
{
    using System;
    using FoodOrderSystem.Data.Contracts.Models;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Meal : IAuditInfo, IDeletableEntity
    {
        public Meal()
        {
            this.Menus = new HashSet<Menu>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public decimal? Price { get; set; }

        public virtual ICollection<Menu> Menus { get; set; }

        public DateTime CreatedOn { get; set; }

        public bool PreserveCreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }
    }
}