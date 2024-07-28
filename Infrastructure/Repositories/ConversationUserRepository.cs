using Application.Repositories;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class ConversationUserRepository: GenericRepository<UserConversation>, IConversationUserRepository
    {
        public ConversationUserRepository(AppDbContext context) : base(context)
        {

        }
    }
}
