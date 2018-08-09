namespace NetChatHub.Hubs.Models
{
    public class ChatMessage
    {
        public string Who { get; set; }
        public string Message { get; set; }
        public string ToWho { get; set; }
    }
}