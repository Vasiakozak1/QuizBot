using System.Threading.Tasks;
using QuizBot.Commands;

namespace QuizBot.Services
{
    public class PollCommantHandler: ICommandHandler<AddPollCommand>
    {
        public Task HandleAsync(AddPollCommand command)
        {
            throw new System.NotImplementedException();
        }
    }
}