using System;
using System.ComponentModel.DataAnnotations;

namespace MVC_Day04.Areas.Hr.Data
{
    public enum Gender
    {
        male,
        female
    }
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required( ErrorMessage = "Field is required" )]
        [MaxLength( 50 , ErrorMessage = "exceeded string max length of 50 char" )]
        [Display( Name = "Name" )]
        public string Name { get; set; } = string.Empty;

        [Display( Name = "Username" )]
        [Required( ErrorMessage = "Field is required" )]
        [MaxLength( 50 , ErrorMessage = "exceeded string max length of 50 char" )]
        public string Username { get; set; } = string.Empty;
        [Required( ErrorMessage = "Field is required" )]
        [Display( Name = "Password" )]
        [DataType( DataType.Password )]
        public string Password { get; set; } = string.Empty;
        [Display( Name = "Gender" )]
        [EnumDataType( typeof( Gender ) )]
        [Required( ErrorMessage = "Field is required" )]
        public Gender Gender { get; set; }
        [Required( ErrorMessage = "Field is required" )]
        [DataType( DataType.Currency )]
        [Display( Name = "Salary" )]
        public decimal Salary { get; set; }
        [Display( Name = "Join date" )]
        [Required( ErrorMessage = "Field is required" )]
        [DataType( DataType.DateTime )]
        public DateTime JoinDate { get; set; } = DateTime.Now;
        [EmailAddress]
        [Required( ErrorMessage = "Field is required" )]
        public string Email { get; set; } = string.Empty;
        [Phone]
        [Required( ErrorMessage = "Field is required" )]
        public string PhoneNum { get; set; } = string.Empty;
    }
}