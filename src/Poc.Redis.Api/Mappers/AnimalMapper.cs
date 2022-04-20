using Poc.Redis.Api.Commands;
using Poc.Redis.Api.Entities;
using System.Collections.Generic;

namespace Poc.Redis.Api.Mappers
{
    public static class AnimalMapper
    {
        public static AnimalCommand ToAnimalCommand(this Animal animal)
        {
            if (animal == null)
                return null;

            return new AnimalCommand
            {
                Id = animal.Id,
                Name = animal.Name,
                Type = animal.Type,
                IsDangerous = animal.IsDangerous
            };
        }

        public static List<AnimalCommand> ToListAnimalCommand(this List<Animal> animals)
        {
            if (animals == null)
                return null;

            var list = new List<AnimalCommand>();

            foreach (var animal in animals)
            {
                list.Add(animal.ToAnimalCommand());
            }

            return list;
        }
    }
}
