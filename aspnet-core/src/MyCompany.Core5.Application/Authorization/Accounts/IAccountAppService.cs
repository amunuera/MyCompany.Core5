using Abp.Application.Services;
using MyCompany.Core5.Authorization.Accounts.Dto;
using System.Threading.Tasks;

namespace MyCompany.Core5.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
