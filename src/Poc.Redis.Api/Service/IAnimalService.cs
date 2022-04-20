using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Poc.Redis.Api.Commands;

namespace Poc.Redis.Api.Service
{
    public interface IAnimalService
    {
        Task<AnimalCommand> GetByIdAsync(Guid id);
        Task<List<AnimalCommand>> GetAsync();
    }
}
