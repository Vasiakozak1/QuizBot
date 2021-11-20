using MediatR;
using Microsoft.AspNetCore.Mvc;
using QuizBot.Models;

namespace QuizBot.Controllers
{
    [ApiController]
    [Route("/api/updates")]
    public class TelegramUpdatesController : ControllerBase
    {
        private IMediator Mediator;
        
        public TelegramUpdatesController(IMediator mediator)
        {
            Mediator = mediator;
        }
        [HttpPost]
        public IActionResult PostUpdates([FromBody] TelegramUpdatesModel model)
        {
            return Ok();
        }
    }
}
