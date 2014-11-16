using EasyPTC.Data;
using EasyPTC.Web.Infrastructure;
using EasyPTC.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EasyPTC.Web.Controllers
{
    public class HomeController : BaseController
    {
        public HomeController(IEasyPtcData data)
            : base(data)
        {

        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
            //return RedirectToAction<HomeController>(h => h.Index());
        }
    }
}