using System.Web.Mvc;
using Abp.Auditing;

namespace MVC5AJ1.Web.Controllers
{
    public class ErrorController : MVC5AJ1ControllerBase
    {
        [DisableAuditing]
        public ActionResult E404()
        {
            return View();
        }
    }
}