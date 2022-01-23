using QuizBot.Data.Abstractions;
using QuizBot.Models;

namespace QuizBot.Services
{
    public interface ICommandParser
    {
        ICommand Parse<TClientCommand>(TClientCommand command) where TClientCommand : IClientCommand;
    }
}