using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConsoleWebApi.Controllers
{

    [ApiController]
    //Set Base Route at the Contoller Level
    [Route("[controller]/[action]")]
    public class ValuesController : ControllerBase
    {
        [Route("~/api/get-all")]
        [Route("~/getall")]
        [Route("~/get-all")]
        public string GetAll()
        {
            return "Hi Man from getAll";
        }

        //[Route("api/create-All")]
        public string CreateAll()
        {
            return "Hi Man from createAll";
        }


        // [Route("books/{id}")]
        [Route("{id}")]
        public string Getbyid(int id)
        {
            return "Book ID: " + id;


        }


      //  [Route("books/{id}/author/{authorid}")]
        public string GetAuthorid(int id, int authorId)
        {
            return "Book ID: " + id + " Author ID: " + authorId;


        }

       // [Route("search")]
        public string SearchBooks(int id, int authorId, string name, int rating, int price)
        {
            return "Your Search results";


        }

    }
}