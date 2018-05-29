using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.EntityConfiguration
{
    public class MembershipConfiguration : EntityTypeConfiguration<MembershipType>
    {
        public MembershipConfiguration()
        {
            Property(m => m.Name)
                .IsRequired()
                .HasMaxLength(255);
                
        }
    }
}