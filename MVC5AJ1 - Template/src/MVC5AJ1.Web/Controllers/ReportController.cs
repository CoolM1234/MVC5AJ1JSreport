using jsreport.MVC;
using jsreport.Types;
using MVC5AJ1.Web.Models.Report;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5AJ1.Web.Controllers
{
    public class ReportController : Controller
    {
        // GET: Report
        public ActionResult Index()
        {
            return View();
        }

        [EnableJsReport()]
        public ActionResult Invoice()
        {
            HttpContext.JsReportFeature().Recipe(Recipe.PhantomPdf)
                .Configure((r) => r.Template.Phantom = new Phantom() { WaitForJS = true });
            return View(InvoiceModel.Example());
        }
    }
}