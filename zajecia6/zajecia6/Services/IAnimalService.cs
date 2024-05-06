using System.Collections;
using zajecia6.Models;

namespace zajecia6.Services;

public interface IAnimalService
{
    IEnumerable<Animal> GetAnimals(string orderBy);
    int AddAnimal(Animal animal);
    int UpdateAnimal(Animal animal);
    int DeleteAnimal(int idAnimal);
}