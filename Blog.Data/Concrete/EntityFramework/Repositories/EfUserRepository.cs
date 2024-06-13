using Blog.Data.Abstract;
using Blog.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using ProgrammersBlog.Blog.Shared.Data.Concrete.EntityFramework;

namespace Blog.Data.Concrete
{
    public class EfUserRepository : EfEntityRepositoryBase<User>,IUserRepository
    {
        public EfUserRepository(DbContext context) : base(context)
        {
        }
    }
}