using Microsoft.Extensions.DependencyInjection;
using QuizBot.Data.Repository;

namespace QuizBot
{
    public static class Extensions
    {
        public static void AddMongoRepository<TType>(this IServiceCollection serviceCollection, string collectionName)
        {
            serviceCollection.AddScoped<IRepository<TType>>(provider =>
            {
                var mongoOptions = provider.GetService<MongoDbOptions>();
                return new MongoRepository<TType>(mongoOptions, collectionName);
            });
        }
    }
}