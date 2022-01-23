using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace QuizBot.Data.Models
{
    public abstract class MongoEntity: IEntity
    {
        [BsonId]
        public ObjectId Id { get; set; }
    }
}