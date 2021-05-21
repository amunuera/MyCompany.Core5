using Abp.Authorization;
using Abp.Runtime.Session;
using MyCompany.Core5.Configuration.Dto;
using System.Threading.Tasks;

namespace MyCompany.Core5.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : Core5AppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
