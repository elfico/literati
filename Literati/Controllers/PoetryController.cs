using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Literati.Controllers
{
    public class PoetryController : Controller
    {
        // GET: Poetry
        public ActionResult Index()
        {
            return View();
        }
    }
}