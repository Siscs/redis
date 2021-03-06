using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Poc.Redis.Api.Commands
{
    public class AnimalCommand
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public AnimalType Type { get; set; }
        public bool IsDangerous { get; set; }
    }
}
