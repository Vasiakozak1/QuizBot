using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;

namespace QuizBot.Data.Models
{
    public class Quiz: MongoEntity
    {
        public const string CollectionName = "quizzes";

        public string Question { get; set; }
        public long CorrectAnswerId { get; set; }
        
        public DateTime QuizPostingDate { get; set; }
        public DateTime QuizEndDate { get; set; }
        
        public IList<Answer> PossibleAnswers = Array.Empty<Answer>();
        public IList<PlayerAnswer> PlayerAnswers = Array.Empty<PlayerAnswer>();
        
        public class Answer
        {
            public long Id { get; set; }
            public string Text { get; set; }
        }

        public class PlayerAnswer
        {
            public long AnswerId { get; set; }
            public long PlayerId { get; set; }
        }
    }
}