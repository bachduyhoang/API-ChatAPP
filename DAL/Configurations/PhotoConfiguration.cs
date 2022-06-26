using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Configurations
{
    public class PhotoConfiguration : IEntityTypeConfiguration<Photo>
    {
        public void Configure(EntityTypeBuilder<Photo> builder)
        {
            builder.ToTable("Photo");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.PublicId).IsRequired(false);
            builder.HasOne(x => x.User).WithMany(x => x.Photos)
                .HasForeignKey(x => x.UserForeignKey);
        }
    }
}
