using HotelManagment_Day11.Models;
using MahApps.Metro.Controls;
using System.Windows;

namespace HotelManagment_Day11.Windows
{
    /// <summary>
    /// Interaction logic for FoodAndMenuWindow.xaml
    /// </summary>
    public partial class FoodAndMenuWindow : MetroWindow
    {


        public FoodAndMenuWindow( Reservation reservation )
        {
            InitializeComponent( );
            DataContext = reservation;

        }
        private void btnNext_Click( object sender , RoutedEventArgs e )
        {

            this.Close( );
        }




    }
}
