using System.Web.Mvc;

namespace MVC_Day04.Areas.Admin.Controllers
{
    [HandleError( View = "AdminErrorPage" )]
    public class StudentsController : Controller
    {
        // GET: Admin/Students
        public ActionResult Index( )
        {
            int x = int.Parse( "asc" );
            return View( );
        }
    }
}