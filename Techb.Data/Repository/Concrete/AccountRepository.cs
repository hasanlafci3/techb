using Techb.Data.Context;
using Techb.Data.Model;
using Techb.Data.Repository.Abstract;

namespace Techb.Data.Repository.Concrete
{
    public class AccountRepository : GenericRepository<Account>, IAccountRepository
    {
        public AccountRepository(AppDbContext context) : base(context)
        {

        }

        public int TotalRecordAsync()
        {
            return Context.Account.Count();
        }
    }
}
