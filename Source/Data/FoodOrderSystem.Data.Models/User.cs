namespace FoodOrderSystem.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Security.Claims;
    using System.Threading.Tasks;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using FoodOrderSystem.Data.Contracts.Models;

    public class User : IdentityUser, IAuditInfo, IDeletableEntity
    {
        public User()
        {
            this.CreatedOn = DateTime.Now;
            this.FavoriteEateries = new HashSet<Eatery>();
            this.ReservedTables=new HashSet<Table>();
        }

        public DateTime CreatedOn { get; set; }

        public bool PreserveCreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn {get;set;}

        public virtual ICollection<Eatery> FavoriteEateries { get; set; }

        public virtual ICollection<Table> ReservedTables { get; set; }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<User> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }
}
