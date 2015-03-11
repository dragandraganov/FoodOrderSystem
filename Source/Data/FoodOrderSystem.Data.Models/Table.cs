namespace FoodOrderSystem.Data.Models
{
    using FoodOrderSystem.Data.Contracts.Models;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;

    public class Table : IAuditInfo, IDeletableEntity
    {
        public Table()
        {
            this.Orders = new HashSet<Order>();
        }

        [Key]
        public int Id { get; set; }

        public string TableNumber { get; set; }

        public ICollection<string> Passwords { get; set; }

        public decimal? Bill { get; set; }

        public int EateryId { get; set; }

        public virtual Eatery Eatery { get; set; }

        public int ReservedByCustomerId { get; set; }

        public virtual User ReservedByCustomer { get; set; }

        public virtual ICollection<Order> Orders { get; set; }

        public DateTime CreatedOn { get; set; }

        public bool PreserveCreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }
    }
}
