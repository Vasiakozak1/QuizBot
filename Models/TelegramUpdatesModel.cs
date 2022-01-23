namespace QuizBot.Models
{
    public class TelegramUpdatesModel: IClientCommand
    {
        public int MessageId { get; set; }
        
        public SenderModel From { get; set; }
        
        public ChatModel Chat { get; set; }

        public PollModel Poll { get; set; }
        
        public int Date { get; set; }
        
        public string Text { get; set; }
    }
}