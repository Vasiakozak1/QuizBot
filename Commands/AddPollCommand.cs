using QuizBot.Data.Abstractions;
using QuizBot.Models;

namespace QuizBot.Commands
{
    public class AddPollCommand : ICommand
    {
        public SenderModel Sender { get; }
        public PollModel Poll { get; }
        public ChatModel Chat { get; }
        
        public AddPollCommand(SenderModel sender, PollModel poll, ChatModel chat)
        {
            Sender = sender;
            Poll = poll;
            Chat = chat;
        }
    }
}