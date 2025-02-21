using System.Linq.Expressions;
using Blog.Shared.Data.Abstract;
using Blog.Shared.Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using ProgrammersBlog.Blog.Shared.Entities.Abstract;

namespace ProgrammersBlog.Blog.Shared.Data.Concrete.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity> : IEntityRepository<TEntity> where TEntity : class, IEntity, new()
    {
        private readonly DbContext _context;


        public EfEntityRepositoryBase(DbContext context)
        {
            _context = context;
        }

        public async Task<TEntity>  AddAsync(TEntity entity)
        {
            await _context.Set<TEntity>().AddAsync(entity);
            return entity;
        }

        public async Task<bool> AnyAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await _context.Set<TEntity>().AnyAsync(predicate);
        }

        public async Task<int> CountAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await _context.Set<TEntity>().CountAsync(predicate);
        }

        public async Task DeleteAsync(TEntity entity)
        {
            await Task.Run(() => { _context.Set<TEntity>().Remove(entity); });
        }

        public async Task<IList<TEntity>> GetAllAsync(
    Expression<Func<TEntity, bool>> predicate = null,
    params Expression<Func<TEntity, object>>[] includeProperties)
        {
            // Veritabanı sorgusunun başlangıç noktası
            IQueryable<TEntity> query = _context.Set<TEntity>();

            // Eğer bir filtre varsa, sorguya ekle
            if (predicate != null)
            {
                query = query.Where(predicate);
            }

            // includeProperties null değilse ve herhangi bir özellik içeriyorsa, her birini sorguya ekle
            if (includeProperties != null && includeProperties.Any())
            {
                foreach (var includeProperty in includeProperties)
                {
                    query = query.Include(includeProperty);
                }
            }

            // Sorguyu çalıştır ve sonuçları liste olarak dön
            return await query.ToListAsync();
        }


        public async Task<TEntity> GetAsync(
         Expression<Func<TEntity, bool>> predicate,
         params Expression<Func<TEntity, object>>[] includeProperties)
        {
            IQueryable<TEntity> query = _context.Set<TEntity>();

            // Predicate'e göre filtre uygula
            query = query.Where(predicate);

            // İlişkili verileri dahil etmek için includeProperties parametresini kullan
            foreach (var includeProperty in includeProperties)
            {
                query = query.Include(includeProperty);
            }

            // İlk eşleşen kaydı getir
            return await query.FirstOrDefaultAsync();
        }



        public async Task<TEntity>  UpdateAsync(TEntity entity)
        {
            await Task.Run(() => { _context.Set<TEntity>().Update(entity); }); 
            return entity;
        }
    }
}