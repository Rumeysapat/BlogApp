using Blog.Date.Abstract;
using Blog.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using ProgrammersBlog.Blog.Shared.Data.Concrete.EntityFramework;

namespace Blog.Data.Concrete
{
    public class EfRoleRepository : EfEntityRepositoryBase<Role>,IRoleRepository
    {
        public EfRoleRepository(DbContext context) : base(context)
        {
        }
    }
}