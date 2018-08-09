using Microsoft.AspNetCore.SignalR;
using NetChatHub.Hubs;
using NetChatHub.Hubs.Models;

namespace NetChatHub.Hubs.Context
{
    public class ChatClient<TChatMessage> : IChatClient<TChatMessage> where TChatMessage : ChatMessage
    {
        readonly IHubContext<MyChatHub> _chatHubContext;
        public ChatClient(IHubContext<MyChatHub> chatHubContext)
        {
            _chatHubContext = chatHubContext;
        }

        public void SendMessage(TChatMessage message)
        {
            _chatHubContext.Clients.Client("connectionId").SendAsync("ChatGelenMessage", message);
        }
    }
}