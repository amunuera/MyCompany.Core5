using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MyCompany.Core5.EntityFrameworkCore;
using MyCompany.Core5.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace MyCompany.Core5.Web.Tests
{
    [DependsOn(
        typeof(Core5WebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class Core5WebTestModule : AbpModule
    {
        public Core5WebTestModule(Core5EntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(Core5WebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(Core5WebMvcModule).Assembly);
        }
    }
}