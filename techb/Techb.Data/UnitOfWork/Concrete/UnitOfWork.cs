using Techb.Data.Context;
using Techb.Data.Model;
using Techb.Data.Repository.Abstract;
using Techb.Data.Repository.Concrete;
using Techb.Data.UnitOfWork.Abstract;

namespace Techb.Data.UnitOfWork.Concrete
{

    public class UnitOfWork : IUnitOfWork
    {

        private readonly AppDbContext dbContext;


        // repos,
        public IGenericRepository<Store> Store { get; private set; }
        public IAccountRepository Account { get; private set; }
        public IBookRepository Book { get; private set; }


        public UnitOfWork(AppDbContext dbContext)
        {
            this.dbContext = dbContext;


            // init repository
            Store = new GenericRepository<Store>(dbContext);
            Book = new BookRepository(dbContext);
            Account = new AccountRepository(dbContext);
        }


        public async Task CompleteAsync()
        {
            await dbContext.SaveChangesAsync();
        }

        public void Dispose()
        {
            dbContext.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
