using HotelManagment_Day11.Windows;
using System.Windows;
using System.Windows.Controls;

namespace HotelManagment_Day11.Pages.KitchenWindowPages
{
    /// <summary>
    /// Interaction logic for TodoPage.xaml
    /// </summary>
    public partial class TodoPage : Page
    {
        public TodoPage( )
        {
            InitializeComponent( );
        }

        private void Cleaning_HandleUnchecked( object sender , RoutedEventArgs e )
        {

        }

        private void Cleaing_HandleUnchecked( object sender , RoutedEventArgs e )
        {

        }

        private void SweetestSurpriseLbl_HandleCheck( object sender , RoutedEventArgs e )
        {

        }

        private void SweetestSurpriseLbl_HandleUnchecked( object sender , RoutedEventArgs e )
        {

        }

        private void TowelsLbl_HandleCheck( object sender , RoutedEventArgs e )
        {

        }

        private void TowelsLbl_HandleUnchecked( object sender , RoutedEventArgs e )
        {

        }

        private void BtnChangeSection_Click( object sender , RoutedEventArgs e )
        {
            new FoodAndMenuWindow( ).Show( );
        }

        private void btnUpdateChanges_Click( object sender , RoutedEventArgs e )
        {

        }

        private void FoodLbl_HandleCheck( object sender , RoutedEventArgs e )
        {

        }

        private void FoodLbl_HandleUnchecked( object sender , RoutedEventArgs e )
        {

        }
    }
}
