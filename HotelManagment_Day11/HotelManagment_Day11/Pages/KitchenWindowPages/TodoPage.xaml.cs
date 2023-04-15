using HotelManagment_Day11.Managers;
using HotelManagment_Day11.Models;
using HotelManagment_Day11.Windows;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using System.Windows;
using System.Windows.Controls;

namespace HotelManagment_Day11.Pages.KitchenWindowPages
{
    /// <summary>
    /// Interaction logic for TodoPage.xaml
    /// </summary>
    public partial class TodoPage : Page
    {
        public static Reservation reservation = new Reservation( );
        ReservationManager _manager = new ReservationManager( );
        MetroWindow metroWindow = (Application.Current.Windows[ 0 ] as MetroWindow);
        public TodoPage( )
        {
            InitializeComponent( );
            DataContext = reservation;
            QueueListBox.SelectionChanged += ( sender , e ) =>
            {
                DataContext = QueueListBox.SelectedItem;
                reservation = ( Reservation ) DataContext;
            };

        }



        private void BtnChangeSection_Click( object sender , RoutedEventArgs e )
        {
            new FoodAndMenuWindow( reservation ).Show( );
        }

        private async void btnUpdateChanges_Click( object sender , RoutedEventArgs e )
        {
            var controller = await metroWindow.ShowProgressAsync( "Please wait..." , "Updating your reservation" );
            int result = _manager.UpdateReservation( reservation );
            await controller.CloseAsync( );
            if ( result != 0 )
            {
                await metroWindow.ShowMessageAsync( "Success" , "Reservation was Updated successfully" );
                BtnNewResevation_Click( );
            }
            else
                await metroWindow.ShowMessageAsync( "Failed" , "Failed to Update your reservation, Try again later" );
        }

        private void BtnNewResevation_Click( )
        {
            reservation = new Reservation( );
            DataContext = reservation;
        }
        private async void LoadListBox( object sender , RoutedEventArgs e )
        {
            var controller = await metroWindow.ShowProgressAsync( "Please wait..." , "Page is loading" );
            QueueListBox.ItemsSource = _manager.RetreaveReservations( );
            QueueListBox.DisplayMemberPath = "DisplayedMember";
            QueueListBox.SelectedValuePath = "Id";
            await controller.CloseAsync( );
        }
    }
}
