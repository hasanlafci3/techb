using Techb.Data.Model;

namespace Techb.Data.Repository.Abstract
{
    public interface IAccountRepository :IGenericRepository<Account>
    {
        int TotalRecordAsync();
    }
}
