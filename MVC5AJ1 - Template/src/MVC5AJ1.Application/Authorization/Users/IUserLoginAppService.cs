using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using MVC5AJ1.Authorization.Users.Dto;

namespace MVC5AJ1.Authorization.Users
{
    public interface IUserLoginAppService : IApplicationService
    {
        Task<ListResultDto<UserLoginAttemptDto>> GetRecentUserLoginAttempts();
    }
}
