using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace MyCompany.Core5.Controllers
{
    public abstract class Core5ControllerBase : AbpController
    {
        protected Core5ControllerBase()
        {
            LocalizationSourceName = Core5Consts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
