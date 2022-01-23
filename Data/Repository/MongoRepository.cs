using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace QuizBot.Data.Repository
{
    public class MongoRepository<TType>: IRepository<TType>
    {
        private IMongoCollection<TType> Collection;
        public MongoRepository(MongoDbOptions mongoOptions, string collectionName)
        {
            var mongoClient = new MongoClient(mongoOptions.ConnectionString);
            var db = mongoClient.GetDatabase(mongoOptions.DatabaseName);
            Collection = db.GetCollection<TType>(collectionName);
        }
        public async Task CreateAsync(TType entity)
        {
            await Collection.InsertOneAsync(entity);
        }

        public Task<TType> GetById(TType entity)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<TType>> GetAll(Expression<Func<TType, bool>> filterExpression)
        {
            return await Collection.Find(filterExpression).ToListAsync();
        }
    }
}