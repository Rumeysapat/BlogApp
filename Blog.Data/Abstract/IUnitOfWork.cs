using Blog.Date.Abstract;

namespace Blog.Data.Abstract
{
    public interface IUnitOfWork:IAsyncDisposable
    {
        IArticleRepository Articles { get; }
        ICategoryRepository Categories { get; }
        ICommentRepository Comments { get; }
        IRoleRepository Roles { get; }
        IUserRepository Users   { get; }
        /*  _unitOfWork.Categories.AddAsyc(Caterory)*/

        Task <int> SaveAsync ();
        
    }
}