namespace FoodOrderSystem.Data.Models
{
    using System.Collections.Generic;
    using FoodOrderSystem.Data.Contracts.Models;
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Order : IAuditInfo, IDeletableEntity
    {
        public Order()
        {
            this.Dishes = new HashSet<Meal>();
        }

        [Key]
        public int Id { get; set; }

        public string CustomerId { get; set; }

        public virtual User Customer { get; set; }

        public int EateryId { get; set; }

        public virtual Eatery Eatery { get; set; }

        public virtual ICollection<Meal> Dishes { get; set; }

        public decimal? Total { get; set; }

        public DateTime CreatedOn { get; set; }

        public bool PreserveCreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }
    }
}
