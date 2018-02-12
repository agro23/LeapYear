using Microsoft.AspNetCore.Mvc;

namespace LeapYear.Controllers
{
    public class HomeController : Controller
    {

        [Route("/")]
        public ActionResult Form()
        {
            return View();
        }
    }
}
