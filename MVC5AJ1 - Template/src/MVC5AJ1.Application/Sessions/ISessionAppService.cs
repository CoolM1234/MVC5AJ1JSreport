using System.Threading.Tasks;
using Abp.Application.Services;
using MVC5AJ1.Sessions.Dto;

namespace MVC5AJ1.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
