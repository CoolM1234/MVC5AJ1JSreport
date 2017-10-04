using Abp.Application.Services;
using MVC5AJ1.Dto;
using MVC5AJ1.Logging.Dto;

namespace MVC5AJ1.Logging
{
    public interface IWebLogAppService : IApplicationService
    {
        GetLatestWebLogsOutput GetLatestWebLogs();

        FileDto DownloadWebLogs();
    }
}
