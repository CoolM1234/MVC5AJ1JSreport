using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using MVC5AJ1.Chat.Dto;

namespace MVC5AJ1.Chat
{
    public interface IChatAppService : IApplicationService
    {
        GetUserChatFriendsWithSettingsOutput GetUserChatFriendsWithSettings();

        Task<ListResultDto<ChatMessageDto>> GetUserChatMessages(GetUserChatMessagesInput input);

        Task MarkAllUnreadMessagesOfUserAsRead(MarkAllUnreadMessagesOfUserAsReadInput input);
    }
}
