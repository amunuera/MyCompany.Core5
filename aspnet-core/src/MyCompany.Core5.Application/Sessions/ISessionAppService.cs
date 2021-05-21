using Abp.Application.Services;
using MyCompany.Core5.Sessions.Dto;
using System.Threading.Tasks;

namespace MyCompany.Core5.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
