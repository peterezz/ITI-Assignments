using System.Web.Mvc;
using Task01.Models;

namespace Task01.Controllers
{
    public class ImageController : Controller
    {
        // GET: Image
        static ImageModel model = new ImageModel( );
        [HttpGet]
        public ActionResult create( )
        {
            return View( );
        }
        [HttpPost]
        public ActionResult create( ImageModel imageModel )
        {
            model.Id = imageModel.Id;
            model.Name = imageModel.Name;
            model.ImagePath = imageModel.ImagePath;
            return RedirectToAction( nameof( preview ) );
        }
        [HttpGet]
        public ActionResult preview( )
        {
            ViewBag.model = model;
            return View( ViewBag.model );
        }
    }
}