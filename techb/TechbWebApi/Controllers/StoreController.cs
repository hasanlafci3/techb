using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Techb.Data.Model;
using Techb.Data.UnitOfWork.Abstract;

namespace TechbWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoreController : ControllerBase
    {

        private readonly IUnitOfWork unitOfWork;
        public StoreController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var stores = await unitOfWork.Store.GetAllAsync();
            return Ok(stores);
        }

        [HttpGet("{id}")]
        public async Task<Store> GetById(int id)
        {
            return await unitOfWork.Store.GetByIdAsync(id);
        }



        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Store store)
        {
            if (ModelState.IsValid)
            {
                store.CreatedAt = System.DateTime.UtcNow;
                store.CreatedBy = "Deny";

                await unitOfWork.Store.InsertAsync(store);
                await unitOfWork.CompleteAsync();

                return Ok(store);
            }

            return new JsonResult("Invalid Request") { StatusCode = 500 };
        }


        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var item = await unitOfWork.Store.GetByIdAsync(id);
            if (item is null)
            {
                return BadRequest();
            }

            unitOfWork.Store.RemoveAsync(item);
            await unitOfWork.CompleteAsync();

            return Ok();
        }

    }
}
