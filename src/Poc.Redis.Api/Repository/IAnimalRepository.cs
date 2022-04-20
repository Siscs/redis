using Poc.Redis.Api.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Poc.Redis.Api.Repository
{
    public interface IAnimalRepository
    {
        Task<Animal> GetByIdAsync(Guid id);

        Task<List<Animal>> GetAsync();
    }
}
