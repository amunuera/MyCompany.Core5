using Abp.Application.Services;
using MyCompany.Core5.MultiTenancy.Dto;

namespace MyCompany.Core5.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

