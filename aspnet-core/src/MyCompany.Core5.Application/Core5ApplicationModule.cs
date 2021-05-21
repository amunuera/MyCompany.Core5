using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MyCompany.Core5.Authorization;

namespace MyCompany.Core5
{
    [DependsOn(
        typeof(Core5CoreModule),
        typeof(AbpAutoMapperModule))]
    public class Core5ApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<Core5AuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(Core5ApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
