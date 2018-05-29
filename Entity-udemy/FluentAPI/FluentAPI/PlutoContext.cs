using FluentAPI.EntityConfiguration;
using FluentAPI.Entitys;
using System.Data.Entity;

namespace FluentAPI
{
    public class PlutoContext : DbContext 
    {
        public DbSet<Courses> Course { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public PlutoContext()
            : base("name=DefaultConnection")
        {        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CoursesConfiguration());


                base.OnModelCreating(modelBuilder);
        }

    }
}
