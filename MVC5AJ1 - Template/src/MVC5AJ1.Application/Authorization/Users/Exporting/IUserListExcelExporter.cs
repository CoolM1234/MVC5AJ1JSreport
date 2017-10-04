using System.Collections.Generic;
using MVC5AJ1.Authorization.Users.Dto;
using MVC5AJ1.Dto;

namespace MVC5AJ1.Authorization.Users.Exporting
{
    public interface IUserListExcelExporter
    {
        FileDto ExportToFile(List<UserListDto> userListDtos);
    }
}