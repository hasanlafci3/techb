using Techb.Data.Context;
using Techb.Data.Model;
using Techb.Data.Repository.Abstract;

namespace Techb.Data.Repository.Concrete
{
    public class BookRepository : GenericRepository<Book>, IBookRepository
    {
        public BookRepository(AppDbContext context) : base(context)
        {

        }

       
    }
}
