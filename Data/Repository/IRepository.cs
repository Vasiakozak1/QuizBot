using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace QuizBot.Data.Repository
{
    public interface IRepository<TType>
    {
        Task CreateAsync(TType entity);
        Task<TType> GetById(TType entity);
        Task<IEnumerable<TType>> GetAll(Expression<Func<TType, bool>> filterExpression);
    }
}