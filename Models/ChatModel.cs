namespace QuizBot.Models
{
    public partial class TelegramUpdatesModel
    {
        public class ChatModel
        {
            public string Id { get; set; }
            
            public string FirstName { get; set; }
            
            public string LastName { get; set; }
            
            public string UserName { get; set; }
            
            public string Type { get; set; }
        }
    }
}