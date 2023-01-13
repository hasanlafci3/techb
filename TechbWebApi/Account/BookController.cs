using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Techb.Data.Model;
using Techb.Data.Repository.Abstract;

namespace TechbWebApi
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {

        private readonly IBookRepository BookRepository;

        public BookController(IBookRepository BookRepository)
        {
            this.BookRepository = BookRepository;
        }


        [HttpGet("FindAsync")]
        public async Task<Book> FindAsync([FromQuery] int id)
        {
            return await BookRepository.GetByIdAsync(id);
        }


        [HttpGet("GetAll")]
        public async Task<IEnumerable<Book>> GetAll()
        {
            return await BookRepository.GetAllAsync();
        }


        [HttpPost]
        public void Post([FromBody] Book Book)
        {
           BookRepository.InsertAsync(Book);
        }


        [HttpPut]
        public void Update([FromBody] Book Book)
        {
            BookRepository.Update(Book);
        }

        [HttpDelete]
        public void Delete([FromBody] Book Book)
        {
            BookRepository.RemoveAsync(Book);
        }


    }
}
