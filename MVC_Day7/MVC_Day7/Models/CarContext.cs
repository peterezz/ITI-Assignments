using System.Collections.Generic;
using System.Linq;

namespace MVC_Day7.Models
{
    public class CarContext
    {
        static HashSet<Car> CarsList { get; set; } = new HashSet<Car>( )
        {
            new Car{ Color="blue" , Manfacture="Manfacture1",Model="Model1", Num=1},
            new Car{ Color="red" , Manfacture="Manfacture2",Model="Model2", Num=2},
            new Car{ Color="blue" , Manfacture="Manfacture3",Model="Model3", Num=3},
            new Car{ Color="green" , Manfacture="Manfacture4",Model="Model4", Num=4},
            new Car{ Color="black" , Manfacture="Manfacture5",Model="Model5", Num=5},
            new Car{ Color="blue" , Manfacture="Manfacture6",Model="Model6", Num=6}
        };
        public HashSet<Car> GetAllCars( ) => CarsList;
        public Car SelectCarById( int id ) => CarsList.FirstOrDefault( car => car.Num == id );
        public void CreateNewCar( Car car ) => CarsList.Add( car );
        public void UpdateCar( Car car )
        {
            var carData = SelectCarById( car.Num );
            carData.Manfacture = car.Manfacture;
            carData.Model = car.Model;
            carData.Color = car.Color;
        }
        public void DeleteCar( int carNum ) => CarsList.Remove( SelectCarById( carNum ) );

    }
}
