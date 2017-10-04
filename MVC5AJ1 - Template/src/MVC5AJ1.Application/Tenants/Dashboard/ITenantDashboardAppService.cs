using Abp.Application.Services;
using MVC5AJ1.Tenants.Dashboard.Dto;

namespace MVC5AJ1.Tenants.Dashboard
{
    public interface ITenantDashboardAppService : IApplicationService
    {
        GetMemberActivityOutput GetMemberActivity();
    }
}
