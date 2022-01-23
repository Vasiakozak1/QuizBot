using System;
using QuizBot.Commands;
using QuizBot.Data.Abstractions;
using QuizBot.Models;

namespace QuizBot.Services
{
    public class TelegramUpdateParser: ICommandParser
    {
        public ICommand Parse<TClientCommand>(TClientCommand command) where TClientCommand : IClientCommand
        {
            if (command is TelegramUpdatesModel telegramUpdatesModel)
            {
                if (telegramUpdatesModel.Poll is not null)
                    return new AddPollCommand(telegramUpdatesModel.From, telegramUpdatesModel.Poll, telegramUpdatesModel.Chat);
                if (telegramUpdatesModel.Text is not null)
                    return new HandleTextMessageCommand(telegramUpdatesModel.From, telegramUpdatesModel.Chat,
                        telegramUpdatesModel.Text);
            }

            throw new NotImplementedException($"Command {command.GetType().Name} is not supported");
        }
    }
}