﻿using System;
using Abp;
using Abp.Domain.Services;

namespace MVC5AJ1.Chat
{
    public interface IChatMessageManager : IDomainService
    {
        void SendMessage(UserIdentifier sender, UserIdentifier receiver, string message, string senderTenancyName, string senderUserName, Guid? senderProfilePictureId);

        long Save(ChatMessage message);

        int GetUnreadMessageCount(UserIdentifier userIdentifier, UserIdentifier sender);
    }
}
