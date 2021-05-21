using Abp.Modules;
using Abp.Reflection.Extensions;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using MyCompany.Core5.Configuration;

namespace MyCompany.Core5.Web.Host.Startup
{
    [DependsOn(
       typeof(Core5WebCoreModule))]
    public class Core5WebHostModule : AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public Core5WebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(Core5WebHostModule).GetAssembly());
        }
    }
}
