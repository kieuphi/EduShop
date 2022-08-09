using Abp.Authorization;
using EduShop.Authorization.Roles;
using EduShop.Authorization.Users;

namespace EduShop.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
