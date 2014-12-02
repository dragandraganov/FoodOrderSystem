namespace FoodOrderSystem.Data.Models
{
    using System;
    using FoodOrderSystem.Data.Contracts.Models;
    using System.ComponentModel.DataAnnotations;

    public class Eatery : IAuditInfo, IDeletableEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string Phone { get; set; }

        [Required]
        public string Email { get; set; }

        public string ContactPerson { get; set; }

        [Required]
        public int TownId { get; set; }

        public virtual Town Town { get; set; }

        [Required]
        public int EateryCategoryId { get; set; }

        public virtual EateryCategory EateryCategory { get; set; }

        public int? PrimaryMenuId { get; set; }

        public virtual Menu PrimaryMenu { get; set; }

        public int? LunchMenuId { get; set; }

        public virtual Menu LunchMenu { get; set; }

        public DateTime CreatedOn { get; set; }

        public bool PreserveCreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }
    }
}
