//Jovann Contreras
//Date: 10/27/2022
//Peer reviewed by: Rafael Manzo Program ran then after about 10 populations it would retrun blank, otherwise i enjoyed the functionlty and is pretty cool


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
                     break;
                case 2:
                    response = "Yes";
                    break;
                case 3:
                    response = "Most likely";
                     break;
                case 4:
                    response = "Uncertain";
                     break;
                case 5:
                    response = "No";
                    break;
                case 6:
                    response = "Could happen";
                    break;
                case 7:
                    response = "Chances are low";
                    break;
                case 8:
                    response = "Don't count on it";
                    break;
                case 9:
                    response = "Definitley";
                     break;
                case 10:
                    response = "Ask again later";
                     break;
                case 11:
                    response = "Do not know right now";
                    break;
                case 12:
                    response = "Answer is still no";
                   break;
                case 14:
                    response = "As I see it yes";
                    break;
                case 15:
                    response = "Don't ask again";
                    break;
                case 16:
                    response = "Outlook not so good";
                   break;
                case 17:
                    response = "My reply is no";
                    break;
                case 18:
                    response = "Doubtful";
                    break;
                case 19:
                    response = "Without a doubt";
                   break;
                case 20:
                    response = "Dont get your hopes up";
                 break;
            }
            return response;
        }
    }
}