using Abp.Application.Services;
using Abp.Application.Services.Dto;
using MVC5AJ1.Authorization.Permissions.Dto;

namespace MVC5AJ1.Authorization.Permissions
{
    public interface IPermissionAppService : IApplicationService
    {
        ListResultDto<FlatPermissionWithLevelDto> GetAllPermissions();
    }
}
