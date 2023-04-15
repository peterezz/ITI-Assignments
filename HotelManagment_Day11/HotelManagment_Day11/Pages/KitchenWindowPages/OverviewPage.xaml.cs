using HotelManagment_Day11.Managers;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using System.Windows;
using System.Windows.Controls;

namespace HotelManagment_Day11.Pages.KitchenWindowPages
{
    /// <summary>
    /// Interaction logic for OverviewPage.xaml
    /// </summary>
    public partial class OverviewPage : Page
    {
        AdvViewManager _manager = new AdvViewManager( );
        MetroWindow metroWindow = (Application.Current.Windows[ 0 ] as MetroWindow);
        public OverviewPage( )
        {
            InitializeComponent( );
        }


        private async void LoadMainTable( object sender , RoutedEventArgs e )
        {
            var controller = await metroWindow.ShowProgressAsync( "Please wait..." , "Retreaving the reservations" );
            OverviewTable.ItemsSource = _manager.RetrieveAllReservations( );
            await controller.CloseAsync( );
            OverviewTable.Visibility = Visibility.Visible;
        }
    }
}
