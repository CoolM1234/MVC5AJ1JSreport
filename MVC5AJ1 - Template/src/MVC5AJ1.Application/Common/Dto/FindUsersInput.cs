using MVC5AJ1.Dto;

namespace MVC5AJ1.Common.Dto
{
    public class FindUsersInput : PagedAndFilteredInputDto
    {
        public int? TenantId { get; set; }
    }
}