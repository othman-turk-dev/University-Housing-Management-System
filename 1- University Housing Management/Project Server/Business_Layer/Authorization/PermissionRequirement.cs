using Business_Layer.Global.Enums;
using Microsoft.AspNetCore.Authorization;

namespace Business_Layer.Authorization
{
    public class PermissionRequirement : IAuthorizationRequirement
    {
        public UserPermission Permission { get; }

        public PermissionRequirement(UserPermission permission)
        {
            Permission = permission;
        }
    }
}
