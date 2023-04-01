using System.Collections.Generic;
using System.Linq;

namespace Task01.Models
{
    public class CarContext
    {
        static HashSet<CarModel> CarsList { get; set; } = new HashSet<CarModel>( )
        {
            new CarModel{ Color="blue" , Manfacture="Manfacture1",Model="Model1", Num=1},
            new CarModel{ Color="red" , Manfacture="Manfacture2",Model="Model2", Num=2},
            new CarModel{ Color="blue" , Manfacture="Manfacture3",Model="Model3", Num=3},
            new CarModel{ Color="green" , Manfacture="Manfacture4",Model="Model4", Num=4},
            new CarModel{ Color="black" , Manfacture="Manfacture5",Model="Model5", Num=5},
            new CarModel{ Color="blue" , Manfacture="Manfacture6",Model="Model6", Num=6}
        };
        public HashSet<CarModel> GetAllCars( ) => CarsList;
        public CarModel SelectCarById( int id ) => CarsList.FirstOrDefault( car => car.Num == id );
        public void CreateNewCar( CarModel car ) => CarsList.Add( car );
        public void UpdateCar( CarModel car )
        {
            var carData = SelectCarById( car.Num );
            carData.Manfacture = car.Manfacture;
            carData.Model = car.Model;
            carData.Color = car.Color;
        }
        public void DeleteCar( int carNum ) => CarsList.Remove( SelectCarById( carNum ) );





    }
}