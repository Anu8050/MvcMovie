using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Welcome(string name, int id = 1)
        {
            ViewBag.Message = "Hello " + name;
            ViewBag.Id = id;

            return View();
        }
    }
}