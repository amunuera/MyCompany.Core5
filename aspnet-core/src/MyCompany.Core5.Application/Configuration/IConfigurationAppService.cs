using MyCompany.Core5.Configuration.Dto;
using System.Threading.Tasks;

namespace MyCompany.Core5.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
