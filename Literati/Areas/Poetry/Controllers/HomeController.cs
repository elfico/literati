using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Literati.Areas.Poetry.Controllers
{
    public class HomeController : Controller
    {
        // GET: Poetry/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}