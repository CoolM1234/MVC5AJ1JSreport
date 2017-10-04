using System.Collections.Generic;
using MVC5AJ1.Auditing.Dto;
using MVC5AJ1.Dto;

namespace MVC5AJ1.Auditing.Exporting
{
    public interface IAuditLogListExcelExporter
    {
        FileDto ExportToFile(List<AuditLogListDto> auditLogListDtos);
    }
}
