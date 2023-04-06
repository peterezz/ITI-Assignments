using MVC_Day5.Data;
using MVC_Day5.Models;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace MVC_Day5.Controllers
{
    [RoutePrefix( "cstmr" )]
    public class CustomersController : Controller
    {
        private MVC_Day05Context db = new MVC_Day05Context( );

        // GET: Customers
        [Route( "all" )]
        public ActionResult Index( )
        {
            return View( db.Customers.ToList( ) );
        }

        // GET: Customers/Details/5
        [Route( "{id:int}/details" )]
        public ActionResult Details( int? id )
        {
            if ( id == null )
            {
                return new HttpStatusCodeResult( HttpStatusCode.BadRequest );
            }
            Customer customer = db.Customers.Find( id );
            if ( customer == null )
            {
                return HttpNotFound( );
            }
            return View( customer );
        }

        // GET: Customers/Create
        [Route( "" )]
        public ActionResult Create( )
        {
            return View( );
        }

        // POST: Customers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route( "" )]

        public ActionResult Create( [Bind( Include = "Id,Name,Gender,Email,PhoneNum" )] Customer customer )
        {
            if ( ModelState.IsValid )
            {
                db.Customers.Add( customer );
                db.SaveChanges( );
                return RedirectToAction( "Index" );
            }

            return View( customer );
        }

        // GET: Customers/Edit/5
        [Route( "~/{id:int:min(2)}/edit" )]

        public ActionResult Edit( int? id )
        {
            if ( id == null )
            {
                return new HttpStatusCodeResult( HttpStatusCode.BadRequest );
            }
            Customer customer = db.Customers.Find( id );
            if ( customer == null )
            {
                return HttpNotFound( );
            }
            return View( customer );
        }

        // POST: Customers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route( "~/{id:int:min(2)}/edit" )]

        public ActionResult Edit( [Bind( Include = "Id,Name,Gender,Email,PhoneNum" )] Customer customer )
        {
            if ( ModelState.IsValid )
            {
                db.Entry( customer ).State = EntityState.Modified;
                db.SaveChanges( );
                return RedirectToAction( "Index" );
            }
            return View( customer );
        }

        // GET: Customers/Delete/5
        public ActionResult Delete( int? id )
        {
            if ( id == null )
            {
                return new HttpStatusCodeResult( HttpStatusCode.BadRequest );
            }
            Customer customer = db.Customers.Find( id );
            if ( customer == null )
            {
                return HttpNotFound( );
            }
            return View( customer );
        }

        // POST: Customers/Delete/5
        [HttpPost, ActionName( "Delete" )]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed( int id )
        {
            Customer customer = db.Customers.Find( id );
            db.Customers.Remove( customer );
            db.SaveChanges( );
            return RedirectToAction( "Index" );
        }

        protected override void Dispose( bool disposing )
        {
            if ( disposing )
            {
                db.Dispose( );
            }
            base.Dispose( disposing );
        }
    }
}
