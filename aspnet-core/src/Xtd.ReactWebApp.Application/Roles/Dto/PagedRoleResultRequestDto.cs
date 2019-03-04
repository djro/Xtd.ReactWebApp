using Abp.Application.Services.Dto;

namespace Xtd.ReactWebApp.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

