using Abp.Authorization;
using Backend.Authorization.Roles;
using Backend.Authorization.Users;

namespace Backend.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
