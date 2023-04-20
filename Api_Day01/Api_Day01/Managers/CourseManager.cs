using Api_Day01.Models;
using Api_Day01.Repository;

namespace Api_Day01.Managers
{
    public class CourseManager
    {
        private readonly BaseRepo<Course> _repo;

        public CourseManager( CrsDbContext crsDbContext )
        {
            _repo = new BaseRepo<Course>( crsDbContext );
        }

        //GetAll courses
        public List<Course> GetAll( )
        {
            return _repo.GetAll( ).ToList( );
        }
        //GetCourseByID
        public Course GetCourseByID( int id )
        {
            return _repo.Get( id );
        }

        //Add course
        public void AddCourse( Course course )
        {
            _repo.Add( course );
        }
        //Update course
        public int UpdateCourse( int Id , Course course )
        {
            if ( Id != course.Id )
                return 400;
            var data = GetCourseByID( Id );
            if ( data == null )
                return 404;
            data.Duration = course.Duration;
            data.Cs_desc = course.Cs_desc;
            data.Crs_Name = course.Crs_Name;
            _repo.Edit( data );
            return 204;
        }
        // DeleteCourse
        public Course DeleteCourse( int courseID )
        {
            var data = GetCourseByID( courseID );
            if ( data == null )
                return null;
            _repo.Delete( courseID );
            return data;
        }
        // GetCourseByName
        public Course GetCourseByName( string name )
        {
            return _repo.GetOne( course => course.Crs_Name.Equals( name ) );
        }


    }
}
