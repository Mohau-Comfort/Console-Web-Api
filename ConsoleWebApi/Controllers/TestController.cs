using Microsoft.AspNetCore.Mvc;
using System;

namespace ConsoleWebApi.Controllers
{
    [ApiController]
    [Route("test/[action]")]
    public class TestController : ControllerBase
    {
        public string Get()
        {
            return "Hello from Get";
        }

        public string Get1()
        {
            return "Hello from Get";
        }
    }
}
