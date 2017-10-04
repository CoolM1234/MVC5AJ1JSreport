using System.Threading.Tasks;
using Abp.Application.Services;
using MVC5AJ1.Configuration.Tenants.Dto;

namespace MVC5AJ1.Configuration.Tenants
{
    public interface ITenantSettingsAppService : IApplicationService
    {
        Task<TenantSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(TenantSettingsEditDto input);

        Task ClearLogo();

        Task ClearCustomCss();
    }
}
