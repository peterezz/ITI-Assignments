using Api_Day01.Managers;
using Api_Day01.Models;
using Microsoft.AspNetCore.Mvc;

namespace Api_Day01.Controllers
{
    [ApiController]
    [Route( "[controller]" )]
    public class CoursesController : ControllerBase
    {
        private readonly CourseManager _manager;

        public CoursesController( CourseManager courseManager )
        {
            this._manager = courseManager;
        }
        [HttpGet]
        public ActionResult<List<Course>> GetAllCourses( )
        {
            var data = _manager.GetAll( );
            if ( data.Count == 0 )
                return NotFound( );
            return Ok( data );
        }
        [HttpDelete]
        public ActionResult<Course> DeleteCourse( int id )
        {
            var Result = _manager.DeleteCourse( id );
            if ( Result == null )
                return NotFound( );
            return Ok( Result );
        }
        [HttpPut]
        public ActionResult UpdateCourse( int id , Course course )
        {
            var statusCode = _manager.UpdateCourse( id , course );
            if ( statusCode == 400 )
                return BadRequest( );
            if ( statusCode == 404 )
                return NotFound( );
            return Ok( );
        }
        [HttpPost]
        public ActionResult AddCourse( Course course )
        {
            if ( string.IsNullOrEmpty( course.Crs_Name ) || string.IsNullOrEmpty( course.Cs_desc ) || course.Duration == 0 )
                return BadRequest( );
            _manager.AddCourse( course );
            return Ok( course );
        }
        [HttpGet( "{ID:int}" )]
        public ActionResult<Course> GetCourseById( int ID )
        {
            var data = _manager.GetCourseByID( ID );
            if ( data == null ) return NotFound( );
            return Ok( data );
        }
        [HttpGet( "{name}" )]
        public ActionResult<Course> GetCourseByName( string name )
        {
            var data = _manager.GetCourseByName( name );
            if ( data == null ) return NotFound( );
            return Ok( data );
        }
    }
}
