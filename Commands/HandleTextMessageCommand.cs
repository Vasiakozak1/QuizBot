using MediatR;
using QuizBot.Data.Abstractions;
using QuizBot.Models;

namespace QuizBot.Commands
{
    public class HandleTextMessageCommand: ICommand
    {
        public SenderModel Sender { get; }
        public ChatModel Chat { get; }
        public string Text { get; }
        
        public HandleTextMessageCommand(SenderModel sender, ChatModel chat, string text)
        {
            Sender = sender;
            Chat = chat;
            Text = text;
        }
    }
}