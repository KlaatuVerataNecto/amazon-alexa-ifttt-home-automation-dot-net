using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace amazon_alexa_ifttt.Controllers
{
    public class AlexaController : ApiController
    {
        // Important: This is just an example.
        // It is not secure. The system is wide open to the world
        public string Get(int id)
        {
            switch (id)
            {
                case 99999999: HomeAutomation.send_command("OFFICE_ON"); break;
                case 99999991: HomeAutomation.send_command("OFFICE_OFF"); break;
                case 77777771: HomeAutomation.send_command("OFFICE_SHADES_UP"); break;
                case 77777777: HomeAutomation.send_command("OFFICE_SHADES_DOWN"); break;
                case 77777770: HomeAutomation.send_command("OFFICE_SHADES_STOP"); break;
            }
            return "Done!";
        }
    }
}
