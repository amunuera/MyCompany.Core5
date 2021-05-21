using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using MyCompany.Core5.MultiTenancy;

namespace MyCompany.Core5.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}
