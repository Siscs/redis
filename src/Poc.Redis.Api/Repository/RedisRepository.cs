using Microsoft.Extensions.Caching.Distributed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Poc.Redis.Api.Repository
{
    public class RedisRepository : IRedisRepository
    {
        private readonly IDistributedCache _cache;
        private readonly DistributedCacheEntryOptions _cacheOptions;

        public RedisRepository(IDistributedCache cache)
        {
            _cache = cache;

            // colocar no config param
            _cacheOptions = new DistributedCacheEntryOptions
            {
                SlidingExpiration = TimeSpan.FromSeconds(120),
                AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(5)
            };

        }

        public async Task<T> GetAsync<T>(string key)
        {
            var result = await _cache.GetStringAsync(key);

            if (!string.IsNullOrEmpty(result))
            {
                return JsonConvert.DeserializeObject<T>(result);

            }

            return default(T);
        }

        public async Task SetAsync<T>(string key, T obj)
        {
            var stringData = JsonConvert.SerializeObject(obj);
            await _cache.SetStringAsync(key, stringData, _cacheOptions);
        }
    }
}
