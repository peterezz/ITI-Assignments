using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_Day5.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        [Display( Name = "Date" )]
        [Required( ErrorMessage = "Field is required" )]
        [DataType( DataType.DateTime )]
        public DateTime Date { get; set; } = DateTime.Now;
        [Required( ErrorMessage = "Field is required" )]
        [DataType( DataType.Currency )]
        [Display( Name = "Total Price" )]
        [CheckEqualityDataAnnotation( 20 )]
        public int TotalPrice { get; set; }
        [ForeignKey( "customer" )]
        public int Customer_ID { get; set; }
        public Customer customer { get; set; }
    }
}