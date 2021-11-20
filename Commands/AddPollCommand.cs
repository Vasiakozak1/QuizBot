using QuizBot.Data.Abstractions;
using QuizBot.Models;

namespace QuizBot.Commands
{
    public class AddPollCommand : ICommand
    {
        public AddPollCommand(TelegramUpdatesModel.SenderModel sender, TelegramUpdatesModel.PollModel poll)
        {
            
        }
    }
}