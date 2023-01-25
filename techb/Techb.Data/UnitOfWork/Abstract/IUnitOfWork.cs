using Techb.Data.Model;
using Techb.Data.Repository.Abstract;

namespace Techb.Data.UnitOfWork.Abstract
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<Store> Store { get; }   
        IAccountRepository Account { get; }   
        IBookRepository Book { get; }
        Task CompleteAsync();
    }
}
