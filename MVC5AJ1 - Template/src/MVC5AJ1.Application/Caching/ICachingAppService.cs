using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using MVC5AJ1.Caching.Dto;

namespace MVC5AJ1.Caching
{
    public interface ICachingAppService : IApplicationService
    {
        ListResultDto<CacheDto> GetAllCaches();

        Task ClearCache(EntityDto<string> input);

        Task ClearAllCaches();
    }
}
