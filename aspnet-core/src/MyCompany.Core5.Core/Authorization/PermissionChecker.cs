using Abp.Authorization;
using MyCompany.Core5.Authorization.Roles;
using MyCompany.Core5.Authorization.Users;

namespace MyCompany.Core5.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
