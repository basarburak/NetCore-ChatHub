using NetChatHub.Models;

namespace NetChatHub.Hubs
{
    public class MyChatHub : ChatHub<CustomChatMessage>
    {
        public void SendToUser(CustomChatMessage chatmessage)
        {
            Clients.Caller.SingleChatMessage(chatmessage);
        }
    }
}