using System.Threading.Tasks;

namespace Poc.Redis.Api.Repository
{
    public interface IRedisRepository
    {
        Task<T> GetAsync<T>(string key);

        Task SetAsync<T>(string key, T obj);
    }
}
