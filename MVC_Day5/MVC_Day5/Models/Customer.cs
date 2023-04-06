using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MVC_Day5.Models
{
    public enum Gender
    {
        male,
        female
    }
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        [Required( ErrorMessage = "Field is required" )]
        [MaxLength( 50 , ErrorMessage = "exceeded string max length of 50 char" )]
        [Display( Name = "Name" )]
        public string Name { get; set; } = string.Empty;
        [Display( Name = "Gender" )]
        [EnumDataType( typeof( Gender ) )]
        [Required( ErrorMessage = "Field is required" )]
        public Gender Gender { get; set; }
        [EmailAddress]
        [Required( ErrorMessage = "Field is required" )]
        public string Email { get; set; } = string.Empty;
        [Phone]
        [Required( ErrorMessage = "Field is required" )]
        public string PhoneNum { get; set; } = string.Empty;
        public IEnumerable<Order> Orders { get; set; } = new HashSet<Order>( );


    }
}