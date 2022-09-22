using Microsoft.AspNetCore.Mvc;

namespace Skill_Tracker.Controllers
{
    public class SkillsController : Controller
    {
        [HttpGet]
        [Route("skills")]
        public IActionResult Index()
        { string html = @"<h1> Skills Track </h1>
                  <h2>
              <ol>
                  <li> C# </li>
                  <li>JavaScript</li>
                  <li> Python </li>
              <ol>
                  </h2>";
            return Content(html, "text/html");
        }
            [HttpGet]
            [Route("/skills/form")]
            
            public IActionResult Form()
        {
            string html = @"<form method = 'post'>
            <h2>Date:
            <br />
            <input type='date' name='Date'>
            <h2>
           
           <h2>C#:
           <br />
           <select name = 'skills'>
           <option value= 'learning basics'>Learning Basics</option
           <option value= 'making apps'>Making Apps</option>
           <option value= 'master coder'>Master Coder</option> 
         </select>
         </h2>
   
         <br />

           <h2>Javascript:
           <br />
           <select name = 'skills'>
           <option value= 'learning basics'>Learning Basics</option
           <option value= 'making apps'>Making Apps</option>
           <option value= 'master coder'>Master Coder</option> 
         </select>
         </h2>

         <br />

         <h2>Python:
           <br />
           <select name = 'skills'>
           <option value= 'learning basics'>Learning Basics</option
           <option value= 'making apps'>Making Apps</option>
           <option value= 'master coder'>Master Coder</option> 
         </select>
         </h2>
       
        </form>";

            return Content(html, "text/html");

}


            
        }
    }

