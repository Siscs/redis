using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Poc.Redis.Api.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Poc.Redis.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalController : ControllerBase
    {
        private readonly IAnimalService _animalService;

        public AnimalController(IAnimalService animalService)
        {
            _animalService = animalService;
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetByIdAsync(Guid id)
        {
            var result = await _animalService.GetByIdAsync(id);
            return Ok(result);
        }

        [HttpGet]
        [Route("list")]
        public async Task<IActionResult> GetAsync()
        {
            var result = await _animalService.GetAsync();
            return Ok(result);
        }

    }
}
