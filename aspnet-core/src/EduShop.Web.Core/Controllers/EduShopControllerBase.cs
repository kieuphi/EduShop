using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace EduShop.Controllers
{
    public abstract class EduShopControllerBase: AbpController
    {
        protected EduShopControllerBase()
        {
            LocalizationSourceName = EduShopConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
