using Abp.Authorization;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using MyCompany.Core5.Authorization.Roles;
using MyCompany.Core5.Authorization.Users;
using MyCompany.Core5.MultiTenancy;

namespace MyCompany.Core5.Identity
{
    public class SecurityStampValidator : AbpSecurityStampValidator<Tenant, Role, User>
    {
        public SecurityStampValidator(
            IOptions<SecurityStampValidatorOptions> options,
            SignInManager signInManager,
            ISystemClock systemClock,
            ILoggerFactory loggerFactory)
            : base(options, signInManager, systemClock, loggerFactory)
        {
        }
    }
}
