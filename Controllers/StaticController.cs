using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StaticFile.Controllers
{
    public class StaticController : Controller
    {
        public ActionResult Html(string page)
        {
            ViewBag.Page = page;
            return View();
        }
    }
}