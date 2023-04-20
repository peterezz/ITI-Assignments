using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api_Day01.Models
{
    [Table( "Course" )]
    public class Course
    {
        [Key]
        public int Id { get; set; }
        [StringLength( 50 )]
        public string? Crs_Name { get; set; } = string.Empty;
        public string? Cs_desc { get; set; } = string.Empty;
        public int? Duration { get; set; }

    }
}
