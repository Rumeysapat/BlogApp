using Blog.Entities.Concrete;
using Blog.Shared.Data.Abstract;

namespace Blog.Date.Abstract
{
    public interface ICategoryRepository : IEntityRepository<Category>
    {
       
    }
}