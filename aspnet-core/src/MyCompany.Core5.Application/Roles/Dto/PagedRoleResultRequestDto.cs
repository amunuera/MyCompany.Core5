using Abp.Application.Services.Dto;

namespace MyCompany.Core5.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

