using System.Threading.Tasks;
using NetChatHub.Hubs.Models;

namespace NetChatHub.Hubs.Chat
{
    public interface IChatHub<TMessage> where TMessage : ChatMessage
    {
        Task SingleChatMessage(TMessage chatMessage);
        Task MultipleChatMessage(TMessage chatMessage);
    }
}