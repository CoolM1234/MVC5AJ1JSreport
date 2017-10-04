using System.Web.Mvc;
using Abp.Auditing;
using Abp.Web.Mvc.Authorization;

namespace MVC5AJ1.Web.Controllers
{
    [AbpMvcAuthorize]
    public class ApplicationController : MVC5AJ1ControllerBase
    {
        [DisableAuditing]
        public ActionResult Index()
        {
            /* Enable next line to redirect to Multi-Page Application */
            /* return RedirectToAction("Index", "Home", new {area = "Mpa"}); */

            return View("~/App/common/views/layout/layout.cshtml"); //Layout of the angular application.
        }
    }
}