using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using BaseProject.Web.Models;

namespace BaseProject.Web.DAL
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Phone> Phones { get; set; }
        
        public DatabaseContext() : base("DefaultConnection") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}