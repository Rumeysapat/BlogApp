
using System.Threading.Tasks;
using System.Linq.Expressions;
using ProgrammersBlog.Blog.Shared.Entities.Abstract;
//Herhangi bir yapı için kullanabileceğimiz metodları barındırır.Ado.net, EF ex.
namespace Blog.Shared.Data.Abstract
{
    public interface IEntityRepository<T> where T : class, IEntity,new()  //veri tabanındaki nesneleri new leyebilirim.
    {
        Task<T> GetAsync(Expression<Func<T,bool>> predicate,params Expression<Func<T,object>>[] includeProperties); // var kullanici = repository.GetAsync(k=>k.Id==15);


        Task<IList<T>> GetAllAsync(Expression<Func<T,bool>> predicate =null,params Expression<Func<T,object>>[]includeProperties );//repository.GetAllAsync(m=>m.Category.Name=="C#", m=>m.Category);

        Task AddAsync(T entity);
        Task DeleteAsync(T entity);
         Task UpdateAsync(T entity);
         Task<bool> AnyAsync(Expression<Func<T,bool>> predicate);
         Task<int> CountAsync(Expression<Func<T,bool>> predicate);


        

    }
}