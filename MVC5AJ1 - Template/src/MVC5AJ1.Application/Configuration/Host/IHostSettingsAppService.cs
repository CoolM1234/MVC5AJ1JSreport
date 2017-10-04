using System.Threading.Tasks;
using Abp.Application.Services;
using MVC5AJ1.Configuration.Host.Dto;

namespace MVC5AJ1.Configuration.Host
{
    public interface IHostSettingsAppService : IApplicationService
    {
        Task<HostSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(HostSettingsEditDto input);

        Task SendTestEmail(SendTestEmailInput input);
    }
}
