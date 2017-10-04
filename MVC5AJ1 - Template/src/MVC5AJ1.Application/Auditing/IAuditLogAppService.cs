using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using MVC5AJ1.Auditing.Dto;
using MVC5AJ1.Dto;

namespace MVC5AJ1.Auditing
{
    public interface IAuditLogAppService : IApplicationService
    {
        Task<PagedResultDto<AuditLogListDto>> GetAuditLogs(GetAuditLogsInput input);

        Task<FileDto> GetAuditLogsToExcel(GetAuditLogsInput input);
    }
}