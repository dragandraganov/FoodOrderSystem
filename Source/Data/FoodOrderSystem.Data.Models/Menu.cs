using System;
using FoodOrderSystem.Data.Contracts.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FoodOrderSystem.Data.Models
{
    public class Menu : IAuditInfo, IDeletableEntity
    {
        public Menu()
        {
            this.DishCategories = new HashSet<DishCategory>();
        }

        [Key]
        public int Id { get; set; }

        public int? EateryId { get; set; }

        public virtual Eatery Eatery { get; set; }

        public virtual ICollection<DishCategory> DishCategories { get; set; }

        public DateTime CreatedOn { get; set; }

        public bool PreserveCreatedOn { get; set; }
   
        public DateTime? ModifiedOn { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }
    }
}