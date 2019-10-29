using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    [CustomActionFilter, CustomResultFilter, CustomAuthorizationFilter, CustomExceptionFilter]
    public class ContactController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}