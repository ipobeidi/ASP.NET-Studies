using FluentAPI.Entitys;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentAPI.EntityConfiguration
{
    public class CoursesConfiguration : EntityTypeConfiguration<Courses>
    {
        public CoursesConfiguration()
        {

            Property(c => c.Title)
            .IsRequired()
            .HasMaxLength(255);

            
            Property(c => c.Description)
            .IsRequired()
            .HasMaxLength(2000);

            HasRequired(c => c.Author)
            .WithMany(a => a.Course)
            .HasForeignKey(c => c.AuthorID)
            .WillCascadeOnDelete(false);


            HasMany(c => c.Tags)
            .WithMany(t => t.Courses)
            .Map(m =>
            {
                m.ToTable("CourseTags");
                m.MapLeftKey("CourseID");
                m.MapRightKey("TagId");
            });


            HasRequired(c => c.Cover)
            .WithRequiredPrincipal(c => c.Courses);
        }

    }
}
