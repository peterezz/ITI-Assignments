using MVC_Day5.Data;
using MVC_Day5.Models;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace MVC_Day5.Controllers
{
    [CustomErrorHandler( )]
    public class OrdersController : Controller
    {
        private MVC_Day05Context db = new MVC_Day05Context( );

        // GET: Orders
        public ActionResult Index( )
        {
            var orders = db.Orders.Include( o => o.customer );
            return View( orders.ToList( ) );
        }
        [HttpPost]
        public ActionResult Index( int CustomerID )
        {
            var FoundCustomer = db.Orders.Any( o => o.Customer_ID == CustomerID );
            if ( !FoundCustomer )
                throw new KeyNotFoundException( );

            return View( db.Orders.Where( orders => orders.Customer_ID == CustomerID ).Include( order => order.customer ).ToList( ) );
        }

        // GET: Orders/Details/5
        public ActionResult Details( int? id )
        {
            if ( id == null )
            {
                return new HttpStatusCodeResult( HttpStatusCode.BadRequest );
            }
            Order order = db.Orders.Find( id );
            if ( order == null )
            {
                return HttpNotFound( );
            }
            return View( order );
        }

        // GET: Orders/Create
        public ActionResult Create( )
        {
            ViewBag.Customer_ID = new SelectList( db.Customers , "Id" , "Name" );
            return View( );
        }

        // POST: Orders/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create( [Bind( Include = "Id,Date,TotalPrice,Customer_ID" )] Order order )
        {
            if ( ModelState.IsValid )
            {
                db.Orders.Add( order );
                db.SaveChanges( );
                return RedirectToAction( "Index" );
            }

            ViewBag.Customer_ID = new SelectList( db.Customers , "Id" , "Name" , order.Customer_ID );
            return View( order );
        }

        // GET: Orders/Edit/5
        public ActionResult Edit( int? id )
        {
            if ( id == null )
            {
                return new HttpStatusCodeResult( HttpStatusCode.BadRequest );
            }
            Order order = db.Orders.Find( id );
            if ( order == null )
            {
                return HttpNotFound( );
            }
            ViewBag.Customer_ID = new SelectList( db.Customers , "Id" , "Name" , order.Customer_ID );
            return View( order );
        }

        // POST: Orders/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit( [Bind( Include = "Id,Date,TotalPrice,Customer_ID" )] Order order )
        {
            if ( ModelState.IsValid )
            {
                db.Entry( order ).State = EntityState.Modified;
                db.SaveChanges( );
                return RedirectToAction( "Index" );
            }
            ViewBag.Customer_ID = new SelectList( db.Customers , "Id" , "Name" , order.Customer_ID );
            return View( order );
        }

        // GET: Orders/Delete/5
        public ActionResult Delete( int? id )
        {
            if ( id == null )
            {
                return new HttpStatusCodeResult( HttpStatusCode.BadRequest );
            }
            Order order = db.Orders.Find( id );
            if ( order == null )
            {
                return HttpNotFound( );
            }
            return View( order );
        }

        // POST: Orders/Delete/5
        [HttpPost, ActionName( "Delete" )]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed( int id )
        {
            Order order = db.Orders.Find( id );
            db.Orders.Remove( order );
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
