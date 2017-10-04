using System.Collections.Generic;

namespace MVC5AJ1.Tenants.Dashboard.Dto
{
    public class GetMemberActivityOutput
    {
        public List<int> TotalMembers { get; set; }

        public List<int> NewMembers { get; set; }
    }
}