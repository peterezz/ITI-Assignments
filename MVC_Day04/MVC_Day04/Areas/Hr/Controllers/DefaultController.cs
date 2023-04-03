using System.Web.Mvc;

namespace MVC_Day04.Areas.Hr.Controllers
{
    [HandleError( View = "HrErrorPage" )]
    public class DefaultController : Controller
    {
        // GET: Hr/Default
        public ActionResult Index( )
        {
            return View( );
        }
    }
}