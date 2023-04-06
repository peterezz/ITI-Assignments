using System.ComponentModel.DataAnnotations;

namespace MVC_Day7.Models
{
    public class Car
    {
        public int Num { get; set; }
        public string Color { get; set; }
        public string Model { get; set; }
        [Display( Name = "Manfacture" )]
        public string Manfacture { get; set; }
    }
}
