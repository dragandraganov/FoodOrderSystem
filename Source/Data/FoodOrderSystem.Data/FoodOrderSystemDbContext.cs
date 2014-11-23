namespace FoodOrderSystem.Data
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using FoodOrderSystem.Data.Migrations;
    using FoodOrderSystem.Data.Models;
    using Microsoft.AspNet.Identity.EntityFramework;

    public class FoodOrderSystemDbContext : IdentityDbContext<User>
    {
        public FoodOrderSystemDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<FoodOrderSystemDbContext,Configuration>());
        }

        public static FoodOrderSystemDbContext Create()
        {
            return new FoodOrderSystemDbContext();
        }

        public virtual IDbSet<Category> Categories { get; set; }
    }
}
