using System.Threading.Tasks;
using Abp.Domain.Policies;

namespace MVC5AJ1.Authorization.Users
{
    public interface IUserPolicy : IPolicy
    {
        Task CheckMaxUserCountAsync(int tenantId);
    }
}
