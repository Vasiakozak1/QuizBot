using System.Threading.Tasks;
using QuizBot.Models;

namespace QuizBot.Services
{
    public class TelegramUpdateHandler: IUpdateHandler<TelegramUpdatesModel>
    {
        public Task HandleAsync(TelegramUpdatesModel update)
        {
            
        }
    }
}