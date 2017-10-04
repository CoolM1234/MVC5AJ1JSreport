using System.Collections.Generic;
using Abp.Application.Services.Dto;
using MVC5AJ1.Authorization.Permissions.Dto;

namespace MVC5AJ1.Authorization.Roles.Dto
{
    public class GetRoleForEditOutput
    {
        public RoleEditDto Role { get; set; }

        public List<FlatPermissionDto> Permissions { get; set; }

        public List<string> GrantedPermissionNames { get; set; }
    }
}