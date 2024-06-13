using Blog.Date.Abstract;
using Blog.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using ProgrammersBlog.Blog.Shared.Data.Concrete.EntityFramework;

namespace Blog.Data.Concrete
{
    public class EfCategoryRepository : EfEntityRepositoryBase<Category>,ICategoryRepository
    {
        public EfCategoryRepository(DbContext context) : base(context)
        {
        }
    }
}