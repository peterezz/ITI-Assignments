using HotelManagment_Day11.Managers;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using System.Windows;
using System.Windows.Controls;

namespace HotelManagment_Day11
{
    /// <summary>
    /// Interaction logic for UniversalSearchPage.xaml
    /// </summary>
    public partial class UniversalSearchPage : Page
    {
        MetroWindow metroWindow = (Application.Current.Windows[ 0 ] as MetroWindow);
        UniversalSearchManager _manager = new UniversalSearchManager( );

        public UniversalSearchPage( )
        {
            InitializeComponent( );
        }

        private async void BtnSearch_Click( object sender , RoutedEventArgs e )
        {
            SearchResultTable.ItemsSource = null;

            var controller = await metroWindow.ShowProgressAsync( "Please wait..." , "Searching your reservation" );
            var result = _manager.RestreaveReservationBySearchKey( TxtSearch.Text );
            await controller.CloseAsync( );
            if ( result.Count != 0 )
            {
                SearchResultTable.Visibility = Visibility.Visible;
                SearchResultTable.ItemsSource = result;
            }
            else
            {
                await metroWindow.ShowMessageAsync( "Failed" , "No Reservations found!" );
                SearchResultTable.Visibility = Visibility.Hidden;

            }
        }
    }
}
