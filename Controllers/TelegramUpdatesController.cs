using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QuizBot.Models;

namespace QuizBot.Controllers
{
    [ApiController]
    [Route("/api/updates")]
    public class TelegramUpdatesController : ControllerBase
    {
        [HttpPost]
        public IActionResult PostUpdates([FromBody] TelegramUpdatesModel model)
        {

            return Ok();
        }
    }
}
