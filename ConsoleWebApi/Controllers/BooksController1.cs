using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConsoleWebApi.Controllers
{
    [ApiController]
    [Route("test/[action]")]
    public class BooksController1 : ControllerBase
    {

        // [Route("books/{id}")]
        [Route("{id:int}")]
        public string Getbyid(int id)
        {
            return "Book ID: " + id;


        }

        // [Route("books/{id}")]
        [Route("{id}")]
        public string GetbyStringid(string id)
        {
            return "Book ID: " + id;


        }

        public string Get1()
        {
            return "Hello from Get";
        }

    }
}
