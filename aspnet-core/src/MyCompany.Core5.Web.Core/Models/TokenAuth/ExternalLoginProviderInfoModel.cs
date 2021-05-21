using Abp.AutoMapper;
using MyCompany.Core5.Authentication.External;

namespace MyCompany.Core5.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
