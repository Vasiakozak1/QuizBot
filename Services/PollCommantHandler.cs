using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using MongoDB.Bson;
using QuizBot.Commands;
using QuizBot.Data.Models;

namespace QuizBot.Services
{
    public class PollCommantHandler: ICommandHandler<AddPollCommand>
    {
        public Task<Unit> Handle(AddPollCommand request, CancellationToken cancellationToken)
        {
            var answers =
                request.Poll.Options.Select((option, index) => new Quiz.Answer {Id = index, Text = option.Text});
            var quiz = new Quiz
            {
                Id = new ObjectId(request.Poll.Id),
                Question = request.Poll.Question,
                CorrectAnswerId = request.Poll.CorrectOptionId,
                PossibleAnswers = answers.ToList()

            };
            return Task.FromResult(Unit.Value);
        }
    }
}
