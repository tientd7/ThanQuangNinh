using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Business;

namespace ThanQuangNinh.Controllers
{
    public class HomeController : Controller
    {
        AuthenticateBusiness authenticateBusiness = new AuthenticateBusiness();
        public ActionResult Index()
        {
            var Roles = authenticateBusiness.GetRolesDto();
            return View(Roles);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}