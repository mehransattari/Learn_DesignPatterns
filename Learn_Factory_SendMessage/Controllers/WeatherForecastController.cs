using Learn_Factory_SendMessage.Services;
using Microsoft.AspNetCore.Mvc;

namespace Learn_Factory_SendMessage.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IMessageSender messageSender;

        public WeatherForecastController( IMessageSender messageSender)
        {
            this.messageSender = messageSender;
        }


        [HttpGet]
        public string Get()
        {
           return messageSender.SendMessage("Success Buy!!!");
        }

      
    }
}
