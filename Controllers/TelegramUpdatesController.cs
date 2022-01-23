using System.IO;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using QuizBot.Data.Abstractions;
using QuizBot.Models;
using QuizBot.Services;

namespace QuizBot.Controllers
{
    [ApiController]
    [Route("/api/updates")]
    public class TelegramUpdatesController : ControllerBase
    {
        private IMediator Mediator;
        private ICommandParser CommandParser;
        
        public TelegramUpdatesController(IMediator mediator, ICommandParser commandParser)
        {
            Mediator = mediator;
            CommandParser = commandParser;
        }
        [HttpPost]
        public async Task<IActionResult> PostUpdates([FromBody] TelegramUpdatesModel model)
        {
            ICommand command = CommandParser.Parse(model);
            await Mediator.Send(command);
            return Ok();
        }
    }
}
