using FriendOrganiser.Model;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace FriendOrganiser.DataAccess
{
    public class FriendOrganiserDbContext : DbContext
    {
        public FriendOrganiserDbContext() :base("FriendOrganiserDb")
        {

        }
        public DbSet<Friend> Friends { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
