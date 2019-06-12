using CH.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace CH.DAL
{
    public class SchoolContext : DbContext
    {

        //public SchoolContext() : base("SchoolContext")
        //{
        //}

        public DbSet<Books> Books { get; set; }
        public DbSet<History> History { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}