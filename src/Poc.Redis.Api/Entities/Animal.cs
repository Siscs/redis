using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Poc.Redis.Api.Entities
{
    public class Animal
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public AnimalType Type { get; private set; }
        public bool IsDangerous { get; private set; }

        public Animal(Guid id, string name, AnimalType type, bool isDangerous)
        {
            Id = id;
            Name = name;
            Type = type;
            IsDangerous = isDangerous;
        }

    }
}
