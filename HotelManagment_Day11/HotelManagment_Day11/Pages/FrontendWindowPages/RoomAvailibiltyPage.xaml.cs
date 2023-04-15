using HotelManagment_Day11.Managers;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using System.Windows;
using System.Windows.Controls;


namespace HotelManagment_Day11.FrontendWindowPages
{
    /// <summary>
    /// Interaction logic for RoomAvailibiltyPage.xaml
    /// </summary>
    public partial class RoomAvailibiltyPage : Page
    {
        RoomAvailabiltyManager _manager = new RoomAvailabiltyManager( );
        MetroWindow metroWindow = (Application.Current.Windows[ 0 ] as MetroWindow);
        public RoomAvailibiltyPage( )
        {
            InitializeComponent( );
        }

        private async void LoadAllTables( object sender , System.Windows.RoutedEventArgs e )
        {
            var controller = await metroWindow.ShowProgressAsync( "Please wait..." , "Committing your reservation" );
            OccupiedLstBx.ItemsSource = _manager.RetreaveOuccupiedReservers( );
            ReservedLstBx.ItemsSource = _manager.RetreaveReservedReservers( );
            await controller.CloseAsync( );
        }
    }
}
