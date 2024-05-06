using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using zajecia6.Models;
using zajecia6.Services;

namespace zajecia6.Controllers;
[Route("api/animals")]
[ApiController]
public class AnimalController : ControllerBase
{
    private IAnimalService _animalService;

    public AnimalController(IAnimalService animalService)
    {
        _animalService = animalService;
    }
    
    [HttpGet]
    public IActionResult GetAnimals(string orderBy = "name")
    {
        IEnumerable<Animal> animals = _animalService.GetAnimals(orderBy);
        return Ok(animals);
    }

    [HttpPost]
    public IActionResult AddAnimal(Animal animal)
    {
        int affectedCount = _animalService.AddAnimal(animal);
        return StatusCode(StatusCodes.Status201Created);
    }

    [HttpPut]
    public IActionResult UpdateAnimal(Animal animal)
    {
        int affectedCount = _animalService.UpdateAnimal(animal);
        return NoContent();
    }
    
    [HttpDelete("{idAnimal:int}")]
    public IActionResult DeleteAnimal(int idAnimal)
    {
        int affectedCount = _animalService.DeleteAnimal(idAnimal);
        return NoContent();
    }
}