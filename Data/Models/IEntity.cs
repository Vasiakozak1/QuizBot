using MongoDB.Bson;

namespace QuizBot.Data.Models
{
    public interface IEntity
    {
        ObjectId Id { get; set; }
    }
}