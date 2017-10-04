using System.Web.Mvc;

namespace MVC5AJ1.Web.Controllers
{
    public class HomeController : MVC5AJ1ControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}