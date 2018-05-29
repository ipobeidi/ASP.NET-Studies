using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using Vidly.Models;

namespace Vidly.EntityConfiguration
{
    public class CustomerConfiguration : EntityTypeConfiguration<Customer>
    {
        public CustomerConfiguration()
        {

            Property(c => c.Name)
                .IsOptional()
                .HasMaxLength(255);
            Property(c => c.Birthday)
                .IsOptional();
            
                



        }

    }
}