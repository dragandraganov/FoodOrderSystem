namespace FoodOrderSystem.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using FoodOrderSystem.Data;

    internal sealed class Configuration : DbMigrationsConfiguration<FoodOrderSystem.Data.FoodOrderSystemDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            // TODO: Remove in production
            this.AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(FoodOrderSystemDbContext context)
        {
        }
    }
}
