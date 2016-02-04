using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lesson8ASP.Controllers
{
    public class DiscriController : Controller
    {
        // GET: Discri
        [HttpGet]
        public string Index(int a=0, int b=0, int c=0)
        {
            double d = b*b-4*a*c;
            double x1 = (-1 * b + Math.Sqrt(d)) / 2 * a;
            double x2 = (-1 * b - Math.Sqrt(d)) / 2 * a;
            return d.ToString()+" "+ x1.ToString()+" "+x2.ToString();
        }
    }
}