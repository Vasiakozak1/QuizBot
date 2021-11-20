using System.Collections.Generic;

namespace QuizBot.Models
{
    public partial class TelegramUpdatesModel
    {
        public class PollModel
        {
            public string Id { get; set; }
            public string Question { get; set; }
            public IList<PollOption> Options { get; set; }

            public bool IsAnonymous { get; set; }
            public string Type { get; set; }
            public bool AllowMultipleAnswers { get; set; }
            public int CorrectOptionId { get; set; }
            public string Explanation { get; set; }

            public class PollOption
            {
                public string Text { get; set; }
            }
        }
    }
}