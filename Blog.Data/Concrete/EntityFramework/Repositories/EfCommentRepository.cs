using Blog.Data.Abstract;
using Blog.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using ProgrammersBlog.Blog.Shared.Data.Concrete.EntityFramework;

namespace Blog.Data.Concrete
{
    public class EfCommentRepository : EfEntityRepositoryBase<Comment>, ICommentRepository
    {
        public EfCommentRepository(DbContext context) : base(context)
        {
        }
    }
}