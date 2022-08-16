using ConsoleWebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConsoleWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [Route("")]
        public List<EmployeeModel> GetEmployees()
        {
            return new List<EmployeeModel>() {

                new EmployeeModel() {EmployeeId =1 , EmployeeName = "Minato"},
                new EmployeeModel() {EmployeeId =2 , EmployeeName = "Kushina"}
            };


        }

        [Route("{id}")]
        public IActionResult GetEmployeeId(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }

            return Ok(new List<EmployeeModel>() {

                new EmployeeModel() {EmployeeId =1 , EmployeeName = "Minato"},
                new EmployeeModel() {EmployeeId =2 , EmployeeName = "Kushina"}
            });


        }

        [Route("{id}/basic")]
        public ActionResult<EmployeeModel> GetEmployeeDetails(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }

            return new EmployeeModel() { EmployeeId = 1, EmployeeName = "Employee1" };


        }

    }
}