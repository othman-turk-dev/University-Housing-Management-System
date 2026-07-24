using Microsoft.AspNetCore.Authorization;

namespace Business_Layer.Authorization
{
    public class PermissionHandler
    : AuthorizationHandler<PermissionRequirement>
    {
        protected override Task HandleRequirementAsync(
            AuthorizationHandlerContext context,
            PermissionRequirement requirement)
        {
            var claim = context.User.FindFirst("Permission");

            if (claim == null)
                return Task.CompletedTask;

            int permission = int.Parse(claim.Value);

            // Admin
            if (permission == -1)
            {
                context.Succeed(requirement);
                return Task.CompletedTask;
            }

            // Has Permission
            if ((permission & (int)requirement.Permission) != 0)
            {
                context.Succeed(requirement);
            }

            return Task.CompletedTask;
        }
    }
}
