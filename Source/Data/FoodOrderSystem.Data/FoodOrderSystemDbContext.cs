namespace FoodOrderSystem.Data
{
    using System;
    using System.Linq;
    using FoodOrderSystem.Data.Models;
    using Microsoft.AspNet.Identity.EntityFramework;

    public class FoodOrderSystemDbContext : IdentityDbContext<User>
    {
        public FoodOrderSystemDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static FoodOrderSystemDbContext Create()
        {
            return new FoodOrderSystemDbContext();
        }
    }
}
