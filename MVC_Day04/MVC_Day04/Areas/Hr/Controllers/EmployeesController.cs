using MVC_Day04.Areas.Hr.Data;
using MVC_Day04.Data;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace MVC_Day04.Areas.Hr.Controllers
{
    [HandleError( View = "HrErrorPage" )]
    public class EmployeesController : Controller
    {
        private MVC_Day4Context db = new MVC_Day4Context( );

        // GET: Hr/Employees
        public ActionResult Index( )
        {
            return View( db.Employees.ToList( ) );
        }

        // GET: Hr/Employees/Details/5
        public ActionResult Details( int? id )
        {
            if ( id == null )
            {
                return new HttpStatusCodeResult( HttpStatusCode.BadRequest );
            }
            Employee employee = db.Employees.Find( id );
            if ( employee == null )
            {
                return HttpNotFound( );
            }
            return View( employee );
        }

        // GET: Hr/Employees/Create
        public ActionResult Create( )
        {
            return View( );
        }

        // POST: Hr/Employees/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create( [Bind( Include = "Id,Name,Username,Password,Gender,Salary,JoinDate,Email,PhoneNum" )] Employee employee )
        {
            if ( ModelState.IsValid )
            {
                db.Employees.Add( employee );
                db.SaveChanges( );
                return RedirectToAction( "Index" );
            }

            return View( employee );
        }

        // GET: Hr/Employees/Edit/5
        public ActionResult Edit( int? id )
        {
            if ( id == null )
            {
                return new HttpStatusCodeResult( HttpStatusCode.BadRequest );
            }
            Employee employee = db.Employees.Find( id );
            if ( employee == null )
            {
                return HttpNotFound( );
            }
            return View( employee );
        }

        // POST: Hr/Employees/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit( [Bind( Include = "Id,Name,Username,Password,Gender,Salary,JoinDate,Email,PhoneNum" )] Employee employee )
        {
            if ( ModelState.IsValid )
            {
                db.Entry( employee ).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges( );
                return RedirectToAction( "Index" );
            }
            return View( employee );
        }

        // GET: Hr/Employees/Delete/5
        public ActionResult Delete( int? id )
        {
            if ( id == null )
            {
                return new HttpStatusCodeResult( HttpStatusCode.BadRequest );
            }
            Employee employee = db.Employees.Find( id );
            if ( employee == null )
            {
                return HttpNotFound( );
            }
            return View( employee );
        }

        // POST: Hr/Employees/Delete/5
        [HttpPost, ActionName( "Delete" )]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed( int id )
        {
            Employee employee = db.Employees.Find( id );
            db.Employees.Remove( employee );
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
