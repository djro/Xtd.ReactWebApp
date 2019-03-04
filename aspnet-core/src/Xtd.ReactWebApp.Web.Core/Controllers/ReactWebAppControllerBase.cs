using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Xtd.ReactWebApp.Controllers
{
    public abstract class ReactWebAppControllerBase: AbpController
    {
        protected ReactWebAppControllerBase()
        {
            LocalizationSourceName = ReactWebAppConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
