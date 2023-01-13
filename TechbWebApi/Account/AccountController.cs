using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Techb.Data.Model;
using Techb.Data.Repository.Abstract;

namespace TechbWebApi
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {

        private readonly IAccountRepository accountRepository;

        public AccountController(IAccountRepository accountRepository)
        {
            this.accountRepository = accountRepository;
        }

        [HttpGet("GetCount")]
        public int GetCount()
        {
            var count = accountRepository.TotalRecordAsync();
            return count;
        }

        [HttpGet("FindAsync")]
        public async Task<Account> FindAsync([FromQuery] int id)
        {
            return await accountRepository.GetByIdAsync(id);
        }


        [HttpGet("GetAll")]
        public async Task<IEnumerable<Account>> GetAll()
        {
            return await accountRepository.GetAllAsync();
        }


        [HttpPost]
        public void Post([FromBody] Account account)
        {
           accountRepository.InsertAsync(account);
        }


        [HttpPut]
        public void Update([FromBody] Account account)
        {
            accountRepository.Update(account);
        }

        [HttpDelete]
        public void Delete([FromBody] Account account)
        {
            accountRepository.RemoveAsync(account);
        }


    }
}
