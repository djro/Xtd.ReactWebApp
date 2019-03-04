using System.Threading.Tasks;
using Abp.Application.Services;
using Xtd.ReactWebApp.Authorization.Accounts.Dto;

namespace Xtd.ReactWebApp.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
