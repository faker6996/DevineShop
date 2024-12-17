using DevineShop.Core.Entities;
using DevineShop.Infastructure.Persistence;
using DevineShop.Infastructure.Repositories.Base;

namespace DevineShop.Infastructure.Repositories.CommentRepository
{
    public class CommentRepository: Repository<Comment>, ICommentRepository
    {
        public CommentRepository(ApplicationDbContext context):base(context)
        {
            
        }
    }
}
