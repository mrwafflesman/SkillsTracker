using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SkillsTracker.Controllers
{
    public class SkillsController : Controller
    {
        [HttpGet("/skills")]
        public IActionResult Index()
        {
            string html = "<h1>Skills Tracker</h1>" + 
                          "<h2>Coding skills to learn:</h2>" + 
                          "<ol>" + 
                          "<li>C#</li>" +
                          "<li>Javascript</li>" + 
                          "<li>Python</li>" + 
                          "</ol>";

            return Content(html, "text/html");
        }

        [HttpGet("/skills/form")]
        public IActionResult Form()
        {
            string html = "<form method='post' action='/skills/form'>" + 
                            "<label for='date'>Date: </label>" +
                                "<input type = 'date' id = 'date' name = 'date'" +
                                "value = '2020-10-29'" +
                                "min = '2020-01-01' max = '2020-12-31'>" +
                            "<label for='cSharp'>C#: </label>" +
                                "<select name='cSharp' id='cSharp'>" +
                                    "<option value='Learning to code'>Learing to code</option>" +
                                    "<option value='Making apps'>Making apps</option>" +
                                    "<option value='Master coder'>Master coder</option>" +
                                "</select>" + 
                            "<label for='javascript'>JavaScript: </label>" +
                                "<select name='javascript' id='javascript'>" +
                                    "<option value='Learning to code'>Learing to code</option>" +
                                    "<option value='Making apps'>Making apps</option>" +
                                    "<option value='Master coder'>Master coder</option>" +
                                "</select>" + 
                            "<label for='python'>Python: </label>" +
                                "<select name='python' id='python'>" +
                                    "<option value='Learning to code'>Learing to code</option>" +
                                    "<option value='Making apps'>Making apps</option>" +
                                    "<option value='Master coder'>Master coder</option>" +
                                "</select>" + 
                            "<input type='submit' value='submit'>" +
                          "</form>";

            return Content(html, "text/html");
        }

        [HttpPost("/skills/form")]
        public IActionResult Sumbit(string date = "2020-10-29", string cSharp = "Learning to code", string javascript = "Learning to code", string python = "Learning to code")
        {
            string html = "<h1>" + date + "</h1>" +
                          "<ol>" +
                          "<li>C#: " + cSharp + "</li>" +
                          "<li>Javascript: " + javascript + "</li>" +
                          "<li>Python: " + python + "</li>" +
                          "</ol>";

            return Content(html, "text/html");
        }
    }
}
