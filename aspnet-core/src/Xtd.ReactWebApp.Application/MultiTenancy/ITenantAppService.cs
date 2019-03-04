using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Xtd.ReactWebApp.MultiTenancy.Dto;

namespace Xtd.ReactWebApp.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

