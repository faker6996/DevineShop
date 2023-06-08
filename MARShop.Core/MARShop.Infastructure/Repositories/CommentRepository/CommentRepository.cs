using MARShop.Core.Entities;
using MARShop.Infastructure.Persistence;
using MARShop.Infastructure.Repositories.Base;

namespace MARShop.Infastructure.Repositories.CommentRepository
{
    public class CommentRepository: Repository<Comment>, ICommentRepository
    {
        public CommentRepository(ApplicationDbContext context):base(context)
        {
            
        }
    }
}
