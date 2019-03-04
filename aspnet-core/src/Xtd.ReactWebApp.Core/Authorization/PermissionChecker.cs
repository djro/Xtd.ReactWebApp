using Abp.Authorization;
using Xtd.ReactWebApp.Authorization.Roles;
using Xtd.ReactWebApp.Authorization.Users;

namespace Xtd.ReactWebApp.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
