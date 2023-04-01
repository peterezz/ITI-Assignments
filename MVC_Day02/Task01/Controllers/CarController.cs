using System.Web.Mvc;
using Task01.Models;

namespace Task01.Controllers
{
    public class CarController : Controller
    {
        CarContext carContext;
        public CarController( )
        {
            carContext = new CarContext( );
        }
        // GET: Car
        [HttpGet]
        public ActionResult getall( )
        {
            ViewBag.Cars = carContext.GetAllCars( );
            return View( ViewBag.Cars );
        }
        [HttpGet]
        public ActionResult createnewcar( )
        {
            return View( );
        }
        [HttpPost]
        public ActionResult createnewcar( CarModel car )
        {
            carContext.CreateNewCar( car );
            return RedirectToAction( nameof( getall ) );
        }
        [HttpGet]
        public ActionResult deletecar( int carNum )
        {
            carContext.DeleteCar( carNum );
            return RedirectToAction( nameof( getall ) );
        }
        [HttpGet]
        public ActionResult updatecar( int? carNum )
        {
            var Car = carContext.SelectCarById( carNum ?? 0 );
            return View( Car );
        }
        [HttpPost]
        public ActionResult updatecar( CarModel car )
        {
            carContext.UpdateCar( car );
            return RedirectToAction( nameof( getall ) );
        }
        public ActionResult cardetails( int? carNum )
        {
            var Car = carContext.SelectCarById( carNum ?? 0 );
            return View( Car );
        }
    }
}