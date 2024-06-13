using Blog.Shared.Data.Abstract;
using Blog.Entities.Concrete;
using System.Security;  

namespace Blog.Data
{
    public interface IArticleRepository : IEntityRepository<Article>
    {
    Article add (Article article);

    }
}
