using ConsoleWebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConsoleWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalsController : ControllerBase
    {

        private List<AnimalsModel> animals = null;

        public AnimalsController()
        {

            animals = new List<AnimalsModel>()
            {
                new AnimalsModel() {AnimalId = 1, AnimalName = "Dog"},
                new AnimalsModel() {AnimalId = 2, AnimalName = "Cat" }
            };
        }

        [Route("", Name = "All")]
        public IActionResult getAnimals()
        {
            return Ok(animals);
        }


        [Route("test")]
        public IActionResult getAnimalsTest()
        {
            return Accepted("All");
        }

        [Route("{name}")]
        public IActionResult getAnimalByNamet(string name)
        {
            if(!name.Contains("ABC"))
            {
                return BadRequest();
            }
            return Ok(animals);
        }

        [Route("{id:int}")]
        public IActionResult getAnimalById(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            // return Ok(animals.FirstOrDefault(x => x.AnimalId == id));

            //Status 404 (Not Found Method)
            var animal = animals.FirstOrDefault(x => x.AnimalId == id);
            if (animal == null)
            {
                return NotFound();
            }
            return Ok(animal);
        }

        [HttpPost("")]
        public IActionResult getAnimals(AnimalsModel animal)
        {
            animals.Add(animal);

            return CreatedAtAction("~/api/animals" + animal.AnimalId, animal);
        }

    }
}
