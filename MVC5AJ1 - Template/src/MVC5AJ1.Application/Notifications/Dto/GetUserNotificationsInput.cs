using Abp.Notifications;
using MVC5AJ1.Dto;

namespace MVC5AJ1.Notifications.Dto
{
    public class GetUserNotificationsInput : PagedInputDto
    {
        public UserNotificationState? State { get; set; }
    }
}