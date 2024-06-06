using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: /Helloworld/
        /*The following code:

        Calls the controller's View method.
        Uses a view template to generate an HTML response.
        Controller methods:

        Are referred to as action methods. For example, the Index action method in the preceding code.
        Generally return an IActionResult or a class derived from ActionResult, not a type like string.
        */

        public IActionResult Index()
        {
            return View();
        }

        // GET: /Helloworld/Welcome/
        /*
        In the following sample, the ViewData dictionary was used to pass data from the controller to a view. 
        */
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }

    }
}