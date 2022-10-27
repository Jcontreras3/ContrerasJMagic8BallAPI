//Jovann Contreras
//Date: 10/27/2022
//Peer reviewed by:


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Magic8.Models;

namespace ContrerasJMagic8BallAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MagicController : ControllerBase
    {
          [HttpGet]
        [Route("Magic8")]
        public string MagicChallenge(Magic8Model item)
        {
            string response = "";
            int rannum = 0;
            Random r = new Random();
            rannum = r.Next(1, 20);

            switch (rannum)
            {
                case 1:
                    response = "Maybe";
                    return response;
                case 2:
                    response = "Yes";
                    return response;
                case 3:
                    response = "Most likely";
                    return response;
                case 4:
                    response = "Uncertain";
                    return response;
                case 5:
                    response = "No";
                    return response;
                case 6:
                    response = "Could happen";
                    return response;
                case 7:
                    response = "Chances are low";
                    return response;
                case 8:
                    response = "Don't count on it";
                    return response;
                case 9:
                    response = "Definitley";
                    return response;
                case 10:
                    response = "Ask again later";
                    return response;
                case 11:
                    response = "Do not know right now";
                    return response;
                case 12:
                    response = "Answer is still no";
                    return response;
                case 14:
                    response = "As I see it yes";
                    return response;
                case 15:
                    response = "Don't ask again";
                    return response;
                case 16:
                    response = "Outlook not so good";
                    return response;
                case 17:
                    response = "My reply is no";
                    return response;
                case 18:
                    response = "Doubtful";
                    return response;
                case 19:
                    response = "Without a doubt";
                    return response;
                case 20:
                    response = "Dont get your hopes up";
                    return response;
            }
            return response;
        }
    }
}