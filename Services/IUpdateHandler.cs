using System.Threading.Tasks;
using MediatR;
using QuizBot.Data.Abstractions;

namespace QuizBot.Services
{
    public interface ICommandHandler<in TCommand>: IRequestHandler<TCommand> where TCommand: ICommand
    {
    }
}