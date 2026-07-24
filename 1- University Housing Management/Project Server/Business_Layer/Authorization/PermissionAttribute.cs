using Business_Layer.Global.Enums;
using Microsoft.AspNetCore.Authorization;

namespace Business_Layer.Authorization
{
    public class PermissionAttribute : AuthorizeAttribute
    {
        public PermissionAttribute(UserPermission permission)
        {
            Policy = permission.ToString();
        }
    }
}
