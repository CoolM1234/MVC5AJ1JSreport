using System.Threading.Tasks;
using Abp;
using Abp.Notifications;
using MVC5AJ1.Authorization.Users;
using MVC5AJ1.MultiTenancy;

namespace MVC5AJ1.Notifications
{
    public interface IAppNotifier
    {
        Task WelcomeToTheApplicationAsync(User user);

        Task NewUserRegisteredAsync(User user);

        Task NewTenantRegisteredAsync(Tenant tenant);

        Task SendMessageAsync(UserIdentifier user, string message, NotificationSeverity severity = NotificationSeverity.Info);
    }
}
