using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;

namespace QuizBot.Data.Models
{
    public class Quiz
    {
        [BsonId]
        public long Id { get; set; }
        
        public string Question { get; set; }
        public long CorrectAnswerId { get; set; }
        
        public IList<Answer> PossibleAnswers = Array.Empty<Answer>();
        public IList<PlayerAnswer> PlayerAnswers = Array.Empty<PlayerAnswer>();
        
        public class Answer
        {
            [BsonId]
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