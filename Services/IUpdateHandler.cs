using System.Threading.Tasks;
using QuizBot.Data.Abstractions;

namespace QuizBot.Services
{
    public interface ICommandHandler<in TCommand> where TCommand: ICommand
    {
        Task HandleAsync(TCommand command);
    }
}