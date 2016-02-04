using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lesson8ASP.Controllers
{
    public class ThirdController : Controller
    {

        [HttpGet]
        public ViewResult Index()
        {
            ViewBag.Res = "Аноним";
            ViewBag.Method = Request.HttpMethod;
            return View();
        }
        [HttpPost]
        public ViewResult Index(string field)
        {
            ViewBag.Res = field;
            ViewBag.Method = Request.HttpMethod;
            return View();
        }

    }
}