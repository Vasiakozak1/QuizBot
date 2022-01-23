namespace QuizBot.Models
{
    public class SenderModel
    {
        public string Id { get; set; }

        public bool IsBot { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string UserName { get; set; }
    }
}