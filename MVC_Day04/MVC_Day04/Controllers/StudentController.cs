using MVC_Day04.Models;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace MVC_Day04.Controllers
{
    public class StudentController : Controller
    {
        private ITIEntities db = new ITIEntities( );


        // GET: Students
        [HttpGet]
        public ActionResult Index( int? Dept_Id )
        {
            var departments = db.Departments.ToList( );
            SelectList listDepartments = new SelectList( departments , "Dept_Id" , "Dept_Name" );
            ViewBag.listDepartments = listDepartments;
            IQueryable<Student> students;
            if ( !Dept_Id.HasValue )
                students = db.Students.Include( s => s.Department ).Include( s => s.Student2 );
            else
                students = db.Students.Where( student => student.Dept_Id == Dept_Id ).Include( student => student.Department ).Include( student => student.Student2 );
            return View( students.ToList( ) );
        }
        public ActionResult Index( int Dept_Id )
        {
            return RedirectToAction( "Index" , new { Dept_Id } );
        }

        // GET: Students/Details/5
        public ActionResult Details( int? id )
        {
            if ( id == null )
            {
                return new HttpStatusCodeResult( HttpStatusCode.BadRequest );
            }
            Student student = db.Students.Find( id );
            if ( student == null )
            {
                return HttpNotFound( );
            }
            return View( student );
        }

        // GET: Students/Create
        public ActionResult Create( )
        {
            ViewBag.Dept_Id = new SelectList( db.Departments , "Dept_Id" , "Dept_Name" );
            ViewBag.St_super = new SelectList( db.Students , "St_Id" , "St_Fname" );
            return View( );
        }

        // POST: Students/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create( [Bind( Include = "St_Id,St_Fname,St_Lname,St_Address,St_Age,Dept_Id,St_super" )] Student student )
        {
            if ( ModelState.IsValid )
            {
                db.Students.Add( student );
                db.SaveChanges( );
                return RedirectToAction( "Index" );
            }

            ViewBag.Dept_Id = new SelectList( db.Departments , "Dept_Id" , "Dept_Name" , student.Dept_Id );
            ViewBag.St_super = new SelectList( db.Students , "St_Id" , "St_Fname" , student.St_super );
            return View( student );
        }

        // GET: Students/Edit/5
        public ActionResult Edit( int? id )
        {
            if ( id == null )
            {
                return new HttpStatusCodeResult( HttpStatusCode.BadRequest );
            }
            Student student = db.Students.Find( id );
            if ( student == null )
            {
                return HttpNotFound( );
            }
            ViewBag.Dept_Id = new SelectList( db.Departments , "Dept_Id" , "Dept_Name" , student.Dept_Id );
            ViewBag.St_super = new SelectList( db.Students , "St_Id" , "St_Fname" , student.St_super );
            return View( student );
        }

        // POST: Students/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit( [Bind( Include = "St_Id,St_Fname,St_Lname,St_Address,St_Age,Dept_Id,St_super" )] Student student )
        {
            if ( ModelState.IsValid )
            {
                db.Entry( student ).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges( );
                return RedirectToAction( "Index" );
            }
            ViewBag.Dept_Id = new SelectList( db.Departments , "Dept_Id" , "Dept_Name" , student.Dept_Id );
            ViewBag.St_super = new SelectList( db.Students , "St_Id" , "St_Fname" , student.St_super );
            return View( student );
        }

        // GET: Students/Delete/5
        public ActionResult Delete( int? id )
        {
            if ( id == null )
            {
                return new HttpStatusCodeResult( HttpStatusCode.BadRequest );
            }
            Student student = db.Students.Find( id );
            if ( student == null )
            {
                return HttpNotFound( );
            }
            return View( student );
        }

        // POST: Students/Delete/5
        [HttpPost, ActionName( "Delete" )]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed( int id )
        {
            Student student = db.Students.Find( id );
            db.Students.Remove( student );
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
