using Blog.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using ProgrammersBlog.Blog.Shared.Data.Concrete.EntityFramework;

namespace Blog.Data.Concrete
{
    public class EfArticleRepository : EfEntityRepositoryBase<Article>, IArticleRepository
    {
        public EfArticleRepository(DbContext context) : base(context)
        {
        }

        public Article add(Article article)
        {
            throw new NotImplementedException();
        }
    }
}