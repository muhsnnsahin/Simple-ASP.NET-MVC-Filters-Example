using System.Web;
using System.Web.Mvc;

namespace WebApplication1
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            //filters.Add(new HandleErrorAttribute());
        }
    }

    //filters.Add(new CustomExceptionFilter());
    //filters.Add(new CustomActionFilter());
    //filters.Add(new CustomResultFilter());
    //filters.Add(new CustomAuthorizationFilter());

    public class CustomActionFilter : FilterAttribute, IActionFilter
    {
        //Tanımlandığı seviyede;
        //Action Method çalışmadan önce ve çalıştıktan sonra tetiklenir.

        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            //Action Method'un işi bittikten sonra tetiklenir.
        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            //Action Method'una gidildiğinde tetiklenir.
        }
    }

    public class CustomResultFilter : FilterAttribute, IResultFilter
    {
        //Tanımlandığı seviyede;
        //View görüntülenmeden önce ve görüntülendikten sonra tetiklenir.

        public void OnResultExecuted(ResultExecutedContext filterContext)
        {
            //View görüntülenmeden önce tetiklenir.
        }

        public void OnResultExecuting(ResultExecutingContext filterContext)
        {
            //View görüntülendikten sonra tetiklenir.
        }
    }

    public class CustomAuthorizationFilter : FilterAttribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationContext filterContext)
        {
            //Tanımlandığı seviyede;
            //Action Method çalışmadan önce tetiklenir.
            //Action ve Result Filter'larından önce çalışır.
            //(Exception Filter'ı bilerek bu kümeye katmadım. Çünkü hata olduğunda tetiklendiği için.)
        }
    }

    public class CustomExceptionFilter : FilterAttribute, IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
            //Tanımlandığı seviyede;
            //Hata olduğunda tetiklenir.
        }
    }
}
