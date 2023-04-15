using HotelManagment_Day11.Managers;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using System.Windows;
using System.Windows.Controls;

namespace HotelManagment_Day11.FrontendWindowPages
{
    /// <summary>
    /// Interaction logic for ReservationAdvViewPage.xaml
    /// </summary>
    public partial class ReservationAdvViewPage : Page
    {

        MetroWindow metroWindow = (Application.Current.Windows[ 0 ] as MetroWindow);
        AdvViewManager _manager = new AdvViewManager( );
        public ReservationAdvViewPage( )
        {
            InitializeComponent( );
        }



        private async void LoadMainTable( object sender , RoutedEventArgs e )
        {
            var controller = await metroWindow.ShowProgressAsync( "Please wait..." , "Retreaving reservations" );
            var data = _manager.RetrieveAllReservations( );
            await controller.CloseAsync( );
            if ( data.Count != 0 )
            {
                ReservationsDataGrid.Visibility = Visibility.Visible;
                ReservationsDataGrid.ItemsSource = data;
            }
            else
                await metroWindow.ShowMessageAsync( "SOORY :)" , "No Reservations Found" );


        }
    }
}
