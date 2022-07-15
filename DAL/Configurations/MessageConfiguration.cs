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
    public class MessageConfiguration : IEntityTypeConfiguration<Message>
    {
        public void Configure(EntityTypeBuilder<Message> builder)
        {
            builder.ToTable("Message");
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Recipient).WithMany(x => x.MessagesReceived)
                .HasForeignKey(x => x.RecipentId).OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.Sender).WithMany(x => x.MessagesSent)
                .HasForeignKey(x => x.SenderId).OnDelete(DeleteBehavior.Restrict); ;
        }
    }
}
