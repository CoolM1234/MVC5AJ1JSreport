using System.Threading.Tasks;
using Abp.Configuration;

namespace MVC5AJ1.Timing
{
    public interface ITimeZoneService
    {
        Task<string> GetDefaultTimezoneAsync(SettingScopes scope, int? tenantId);
    }
}
