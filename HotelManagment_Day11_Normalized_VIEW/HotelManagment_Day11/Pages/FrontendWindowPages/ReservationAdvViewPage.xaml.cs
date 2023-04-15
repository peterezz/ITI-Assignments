using HotelManagment_Day11.Managers;
using HotelManagment_Day11.Mappers;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace HotelManagment_Day11.FrontendWindowPages
{
    /// <summary>
    /// Interaction logic for ReservationAdvViewPage.xaml
    /// </summary>
    public partial class ReservationAdvViewPage : Page
    {
        ReservationManager reservationManager = new ReservationManager( );
        MetroWindow metroWindow = (Application.Current.Windows[ 0 ] as MetroWindow);
        public ReservationAdvViewPage( )
        {
            InitializeComponent( );
        }



        private async void LoadMainTable( object sender , RoutedEventArgs e )
        {
            var controller = await metroWindow.ShowProgressAsync( "Please wait..." , "Retreaving reservations" );
            var data = await reservationManager.RetrieveReservationsAsync( );
            await controller.CloseAsync( );
            if ( data != null )
            {
                ReservationsDataGrid.Visibility = Visibility.Visible;
                ReservationsDataGrid.ItemsSource = data.Select( res => res.ToBindingList( ) );
            }
            else
                await metroWindow.ShowMessageAsync( "SOORY :)" , "No Reservations Found" );


        }
    }
}
