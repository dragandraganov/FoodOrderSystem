namespace FoodOrderSystem.Data
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using FoodOrderSystem.Data.Migrations;
    using FoodOrderSystem.Data.Models;
    using Microsoft.AspNet.Identity.EntityFramework;
    using FoodOrderSystem.Data.Contracts.Models;

    public class FoodOrderSystemDbContext : IdentityDbContext<User>
    {
        public FoodOrderSystemDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<FoodOrderSystemDbContext, Configuration>());
        }

        public static FoodOrderSystemDbContext Create()
        {
            return new FoodOrderSystemDbContext();
        }

        public virtual IDbSet<EateryCategory> Categories { get; set; }

        public override int SaveChanges()
        {
            this.ApplyAuditInfoRules();
            this.ApplyDeletableEntityRules();
            return base.SaveChanges();
        }


        private void ApplyAuditInfoRules()
        {
            // Approach via @julielerman: http://bit.ly/123661P
            foreach (var entry in
                this.ChangeTracker.Entries()
                    .Where(
                        e =>
                        e.Entity is IAuditInfo && ((e.State == EntityState.Added) || (e.State == EntityState.Modified))))
            {
                var entity = (IAuditInfo)entry.Entity;

                if (entry.State == EntityState.Added)
                {
                    if (!entity.PreserveCreatedOn)
                    {
                        entity.CreatedOn = DateTime.Now;
                    }
                }
                else
                {
                    entity.ModifiedOn = DateTime.Now;
                }
            }
        }

        private void ApplyDeletableEntityRules()
        {
            // Approach via @julielerman: http://bit.ly/123661P
            foreach (
                var entry in
                    this.ChangeTracker.Entries()
                        .Where(e => e.Entity is IDeletableEntity && (e.State == EntityState.Deleted)))
            {
                var entity = (IDeletableEntity)entry.Entity;

                entity.DeletedOn = DateTime.Now;
                entity.IsDeleted = true;
                entry.State = EntityState.Modified;
            }
        }

    }
}
