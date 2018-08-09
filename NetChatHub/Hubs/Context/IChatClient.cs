using NetChatHub.Hubs.Models;

namespace NetChatHub.Hubs.Context
{
    public interface IChatClient<TMessage> where TMessage : ChatMessage
    {
         void SendMessage(TMessage message);
    }
}