﻿using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Configuration
{
    public class UserConversationConfig : IEntityTypeConfiguration<UserConversation>
    {
        public void Configure(EntityTypeBuilder<UserConversation> builder)
        {
            builder.HasOne(o => o.User)
                   .WithMany(o => o.UserConversations)
                   .HasForeignKey(o => o.UserId);

            builder.HasOne(o => o.Conversation)
                   .WithMany(o => o.UserConversations)
                   .HasForeignKey(o => o.ConversationId);
        }
    }
}
