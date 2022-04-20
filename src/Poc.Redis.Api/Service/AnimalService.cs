using Poc.Redis.Api.Commands;
using Poc.Redis.Api.Mappers;
using Poc.Redis.Api.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Poc.Redis.Api.Service
{
    public class AnimalService : IAnimalService
    {
        private readonly IAnimalRepository _animalRepository;

        public AnimalService(IAnimalRepository animalRepository)
        {
            _animalRepository = animalRepository;
        }

        public async Task<AnimalCommand> GetByIdAsync(Guid id)
        {
            var animal = await _animalRepository.GetByIdAsync(id);
            return animal.ToAnimalCommand();
        }

        public async Task<List<AnimalCommand>> GetAsync()
        {
            var animals = await _animalRepository.GetAsync();
            return animals.ToListAnimalCommand();
        }

    }
}
