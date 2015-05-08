using System.Web.Mvc;
using Recaptcha4Net;

namespace Test.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string name)
        {
            if (Recaptcha.Verify().Success)
            {
                
            }

            return View();
        }
    }
}