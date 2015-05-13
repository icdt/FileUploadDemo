using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BackloadFileUploader.Controllers
{
    using System.IO;

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Basic()
        {
            return View();
        }
        public ActionResult BasicPlus()
        {
            return View();
        }
        public ActionResult AngularJS()
        {
            ViewBag.UserId = "carrie";
            ViewBag.AlbumId = "hongkong";

            return View();
        }
        public ActionResult JQueryUI()
        {
            return View();
        }
    }
}
