using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class BlogController : Controller
    {
        [CustomActionFilter, CustomResultFilter, CustomAuthorizationFilter, CustomExceptionFilter]
        public ActionResult Index()
        {
            return View();
        }
    }
}