namespace FoodOrderSystem.Data.Models
{
    using System;
    using FoodOrderSystem.Data.Contracts.Models;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class MealCategory : IAuditInfo,IDeletableEntity
    {
        public MealCategory()
        {
            this.Dishes = new HashSet<Meal>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public virtual ICollection<Meal> Dishes { get; set; }

        public DateTime CreatedOn { get; set; }

        public bool PreserveCreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }
    }
}