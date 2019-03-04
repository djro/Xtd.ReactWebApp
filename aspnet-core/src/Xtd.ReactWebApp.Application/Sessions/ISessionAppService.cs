using System.Threading.Tasks;
using Abp.Application.Services;
using Xtd.ReactWebApp.Sessions.Dto;

namespace Xtd.ReactWebApp.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
