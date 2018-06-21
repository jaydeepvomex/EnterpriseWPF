namespace FriendOrganiser.DataAccess.Migrations
{
    using Model;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<FriendOrganiser.DataAccess.FriendOrganiserDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(FriendOrganiser.DataAccess.FriendOrganiserDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.Friends.AddOrUpdate(
                f => f.FirstName,
                new Friend { FirstName = "Thomas", LastName = "Huber" },
                new Friend { FirstName = "Andreas", LastName = "Boehler" },
                new Friend { FirstName = "Julia", LastName = "Huber" },
                new Friend { FirstName = "Chrissi", LastName = "Egin" }
                );
        }       
    }           
}
