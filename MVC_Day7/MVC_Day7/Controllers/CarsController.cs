using Microsoft.AspNetCore.Mvc;
using MVC_Day7.Models;

namespace MVC_Day7.Controllers
{
    public class CarsController : Controller
    {
        CarContext carContext = new CarContext( );
        // GET: CarsController
        public ActionResult Index( )
        {
            ViewBag.List = carContext.GetAllCars( );
            return View( ViewBag.List );
        }

        // GET: CarsController/Details/5
        public ActionResult Details( int id )
        {
            ViewBag.CarDetails = carContext.SelectCarById( id );
            return View( ViewBag.CarDetails );
        }

        // GET: CarsController/Create
        public ActionResult Create( )
        {
            return View( );
        }

        // POST: CarsController/Create
        [HttpPost]
        // [ValidateAntiForgeryToken]
        public ActionResult Create( Car car )
        {
            try
            {
                carContext.CreateNewCar( car );
                return RedirectToAction( nameof( Index ) );
            }
            catch
            {
                return View( );
            }
        }

        // GET: CarsController/Edit/5
        public ActionResult Edit( int? carNum )
        {
            var Car = carContext.SelectCarById( carNum ?? 0 );
            return View( Car );
        }

        // POST: CarsController/Edit/5
        [HttpPost]
        // [ValidateAntiForgeryToken]
        public ActionResult Edit( Car car )
        {
            try
            {
                carContext.UpdateCar( car );
                return RedirectToAction( nameof( Index ) );
            }
            catch
            {
                return View( );
            }
        }

        // GET: CarsController/Delete/5
        public ActionResult Delete( int carNum )
        {
            carContext.DeleteCar( carNum );
            return RedirectToAction( nameof( Index ) );
        }


    }
}
