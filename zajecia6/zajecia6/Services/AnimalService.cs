using zajecia6.Models;
using zajecia6.Repositories;

namespace zajecia6.Services;

public class AnimalService : IAnimalService
{
    private readonly IAnimalRepository _animalRepository;

    public AnimalService(IAnimalRepository animalRepository)
    {
        _animalRepository = animalRepository;
    }

    public IEnumerable<Animal> GetAnimals(string orderBy)
    {
        return _animalRepository.GetAnimals(orderBy);
    }

    public int AddAnimal(Animal animal)
    {
        return _animalRepository.AddAnimal(animal);
    }

    public int UpdateAnimal(Animal animal)
    {
        return _animalRepository.UpdateAnimal(animal);
    }

    public int DeleteAnimal(int idAnimal)
    {
        return _animalRepository.DeleteAnimal(idAnimal);
    }
}