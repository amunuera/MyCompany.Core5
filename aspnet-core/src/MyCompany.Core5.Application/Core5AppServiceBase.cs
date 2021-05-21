using Abp.Application.Services;
using Abp.IdentityFramework;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Identity;
using MyCompany.Core5.Authorization.Users;
using MyCompany.Core5.MultiTenancy;
using System;
using System.Threading.Tasks;

namespace MyCompany.Core5
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class Core5AppServiceBase : ApplicationService
    {
        public TenantManager TenantManager { get; set; }

        public UserManager UserManager { get; set; }

        protected Core5AppServiceBase()
        {
            LocalizationSourceName = Core5Consts.LocalizationSourceName;
        }

        protected virtual async Task<User> GetCurrentUserAsync()
        {
            var user = await UserManager.FindByIdAsync(AbpSession.GetUserId().ToString());
            if (user == null)
            {
                throw new Exception("There is no current user!");
            }

            return user;
        }

        protected virtual Task<Tenant> GetCurrentTenantAsync()
        {
            return TenantManager.GetByIdAsync(AbpSession.GetTenantId());
        }

        protected virtual void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
