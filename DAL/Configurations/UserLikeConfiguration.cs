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
    public class UserLikeConfiguration : IEntityTypeConfiguration<UserLike>
    {
        public void Configure(EntityTypeBuilder<UserLike> builder)
        {
            builder.HasKey(x => new { x.CurrentUserId, x.LikedUserId });
            builder.HasOne(x => x.CurrentUser)
                .WithMany(x => x.LikedUsers)
                .HasForeignKey(x => x.CurrentUserId)
                .OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.LikedUser)
                .WithMany(x => x.LikedByUser)
                .HasForeignKey(x => x.LikedUserId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
