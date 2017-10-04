using System.Collections.Generic;
using Abp.Application.Services.Dto;
using MVC5AJ1.Authorization.Permissions.Dto;

namespace MVC5AJ1.Authorization.Users.Dto
{
    public class GetUserPermissionsForEditOutput
    {
        public List<FlatPermissionDto> Permissions { get; set; }

        public List<string> GrantedPermissionNames { get; set; }
    }
}