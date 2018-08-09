using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using NetChatHub.Hubs.Chat;
using NetChatHub.Hubs.Models;

namespace NetChatHub.Hubs
{
    public class ChatHub<TMessage> : Hub<IChatHub<TMessage>> where TMessage : ChatMessage
    {
        public Task SingleChatMessage(TMessage chatMessage)
        {
            return Clients.All.SingleChatMessage(chatMessage);
        }

        public Task MultipleChatMessage(TMessage chatMessage)
        {
            return Clients.All.MultipleChatMessage(chatMessage);
        }
    }
}