using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lesson8ASP.Controllers
{
    public class SecondController : Controller
    {
        // GET: Second
    [HttpGet]
        public ActionResult GetHtml(string[] a)
        {
            string text="<ol>";
            foreach (string item in a)
            {
                text += "<li>" + item + "</li>";
            }
            text += "</ol>";
            return new HtmlResult(text);
         
            
        }
    }
}