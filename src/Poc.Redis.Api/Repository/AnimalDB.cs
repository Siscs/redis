using Poc.Redis.Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Poc.Redis.Api.Repository
{
    public class AnimalDB
    {
        private readonly List<Animal> _animals;

        public AnimalDB()
        {
            _animals = FillAnimals();
        }

        public List<Animal>  GetAnimals()
        {
            return _animals;
        }

        private List<Animal> FillAnimals()
        {
            return new List<Animal>
            {
                new Animal(Guid.NewGuid(), "Marsupial", AnimalType.Mammal, false),
                new Animal(Guid.NewGuid(), "Monkey", AnimalType.Mammal, false),
                new Animal(Guid.NewGuid(), "Dog", AnimalType.Mammal, true),
                new Animal(Guid.NewGuid(), "Cat", AnimalType.Mammal, false),
                new Animal(Guid.NewGuid(), "Bird", AnimalType.Oviparous, false),
                new Animal(Guid.NewGuid(), "Alligator", AnimalType.Reptiles, true),
                new Animal(Guid.NewGuid(), "Snake", AnimalType.Reptiles, true),
                new Animal(Guid.NewGuid(), "Wolf", AnimalType.Mammal, true),
                new Animal(Guid.NewGuid(), "Toad", AnimalType.Amphibians, true),
                new Animal(Guid.NewGuid(), "Mouse", AnimalType.Mammal, true),
                new Animal(Guid.NewGuid(), "Fish", AnimalType.Oviparous, false),
                new Animal(Guid.NewGuid(), "Chicken", AnimalType.Oviparous, false)

            };
        }
    }
}
