using Poc.Redis.Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Poc.Redis.Api.Repository
{
    public class AnimalRepository : IAnimalRepository
    {
        private readonly IRedisRepository _redisRepository;
        private readonly List<Animal> _animals;
        
        public AnimalRepository(AnimalDB animalDB, IRedisRepository redisRepository)
        {
            _redisRepository = redisRepository;
            _animals = animalDB.GetAnimals();
        }

        public async Task<Animal> GetByIdAsync(Guid id)
        {
            var result = await _redisRepository.GetAsync<Animal>(id.ToString());

            if (result != null)
                return result;

            var animal = _animals.Where(p => p.Id.ToString() == id.ToString()).FirstOrDefault();
            
            if(animal != null)
                await _redisRepository.SetAsync<Animal>(id.ToString(), animal);

            return animal;
        }

        public async Task<List<Animal>> GetAsync()
        {
            var key = "animals";
            var result = await _redisRepository.GetAsync<List<Animal>>(key);

            if (!(result is null))
                return result;

            await _redisRepository.SetAsync<List<Animal>>(key, _animals);

            return _animals;
        }
    }
}
