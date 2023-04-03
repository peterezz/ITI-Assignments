using System.Web.Mvc;

namespace MVC_Day04.Areas.Finance.Controllers
{
    [HandleError( View = "FinanceErrorPage" )]
    public class DefaultController : Controller
    {
        // GET: Finance/Default
        public ActionResult Index( )
        {
            int[ ] ints = { 1 , 2 , 3 };
            ints[ 3 ] = 5;
            return View( );
        }
    }
}