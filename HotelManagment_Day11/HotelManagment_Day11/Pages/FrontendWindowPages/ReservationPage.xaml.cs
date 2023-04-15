using HotelManagment_Day11.Managers;
using HotelManagment_Day11.Models;
using HotelManagment_Day11.Windows;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using System.Windows;
using System.Windows.Controls;

namespace HotelManagment_Day11
{

    /// <summary>
    /// Interaction logic for ReservationPagePage.xaml
    /// </summary>
    public partial class ReservationPagePage : Page
    {



        public static Reservation reservation = new Reservation( );
        ReservationManager _manager = new ReservationManager( );
        MetroWindow metroWindow = (Application.Current.Windows[ 0 ] as MetroWindow);

        public ReservationPagePage( )
        {
            InitializeComponent( );
            DataContext = reservation;
            EditReservationCombobox.SelectionChanged += ( sender , e ) =>
            {
                DataContext = EditReservationCombobox.SelectedItem;
                reservation = ( Reservation ) DataContext;
            };

        }

        private void BtnFinalizeBill_Click( object sender , System.Windows.RoutedEventArgs e )
        {

            //BtnSubmit.Visibility = System.Windows.Visibility.Visible;
            new FinalizePaymentWindow( ).Show( );
        }

        private async void BtnSubmit_Click( object sender , System.Windows.RoutedEventArgs e )
        {
            var controller = await metroWindow.ShowProgressAsync( "Please wait..." , "Committing your reservation" );
            reservation.month = MonthComboBox.Text;
            reservation.day = int.Parse( DayComboBox.Text );
            reservation.year = TxtYear.Value.ToString( ) ?? "1999";
            int result = _manager.CreatReservation( reservation );
            await controller.CloseAsync( );
            if ( result != 0 )
            {
                await metroWindow.ShowMessageAsync( "Success" , "Reservation was committed successfully" );
                BtnNewResevation_Click( sender , e );
            }
            else
                await metroWindow.ShowMessageAsync( "Failed" , "Failed to commit your reservation, Try again later\n make sure that you fill all the required fields and registered your services and payment method." );
        }
        private async void BtnEdaitReservation_Click( object sender , System.Windows.RoutedEventArgs e )
        {
            EditionSection.Visibility = System.Windows.Visibility.Visible;
            var controller = await metroWindow.ShowProgressAsync( "Please wait..." , "Page is loading" );
            EditReservationCombobox.ItemsSource = _manager.RetreaveReservations( );
            EditReservationCombobox.DisplayMemberPath = "DisplayedMember";
            EditReservationCombobox.SelectedValuePath = "Id";
            await controller.CloseAsync( );
        }

        private void BtnNewResevation_Click( object sender , RoutedEventArgs e )
        {
            EditionSection.Visibility = System.Windows.Visibility.Hidden;
            reservation = new Reservation( );
            DataContext = reservation;
        }



        private async void BtnUpdate_Click( object sender , RoutedEventArgs e )
        {
            var controller = await metroWindow.ShowProgressAsync( "Please wait..." , "Updating your reservation" );
            int result = _manager.UpdateReservation( reservation );
            await controller.CloseAsync( );
            if ( result != 0 )
            {
                await metroWindow.ShowMessageAsync( "Success" , "Reservation was Updated successfully" );
                BtnNewResevation_Click( sender , e );
            }
            else
                await metroWindow.ShowMessageAsync( "Failed" , "Failed to Update your reservation, Try again later" );
        }

        private void BtnFoodAndMenue_Click( object sender , RoutedEventArgs e )
        {
            new FoodAndMenuWindow( reservation ).Show( );
        }

        private async void BtnDelete_Click( object sender , RoutedEventArgs e )
        {
            var controller = await metroWindow.ShowProgressAsync( "Please wait..." , "Deleting your reservation" );
            int result = _manager.DeleteReservation( reservation );
            await controller.CloseAsync( );
            if ( result != 0 )
            {
                await metroWindow.ShowMessageAsync( "Success" , "Reservation was Deleted successfully" );
                BtnNewResevation_Click( sender , e );
            }
            else
                await metroWindow.ShowMessageAsync( "Failed" , "Failed to Delete your reservation, Try again later" );
        }
        private async void LoadAllComboBoxes( object sender , RoutedEventArgs e )
        {

            var controller = await metroWindow.ShowProgressAsync( "Please wait..." , "Page is loading" );
            #region Gender Combobox
            string[ ] Gender = { "Male" , "Female" , "Others" };
            GenderComboBox.ItemsSource = Gender;
            #endregion
            #region State Combobox
            string[ ] satates = { "Alabama" , "Alaska" , "Arizona" , "Arkansas" , "California" , "Colorado" , "Connecticut" , "Delaware" , "Columbia" , "Florida" , "Georgia" , "Hawaii" , "Idaho" , "Illinois" , "Indiana" , "Iowa" , "Kansas" , "Kentucky" , "Louisiana" , "Maine" };
            StateCombobox.ItemsSource = satates;
            #endregion
            #region Month Combobox
            string[ ] month = new string[ ] { "January" , "February" , "March" , "April" , "May" , "June" , "July" , "August" , "September" , "October" , "November" , "December" };
            MonthComboBox.ItemsSource = month;
            #endregion
            #region Days Combobox
            int[ ] days = { 1 , 2 , 3 , 4 , 5 , 6 , 7 , 8 , 9 , 10 , 11 , 12 , 13 , 14 , 15 , 16 , 17 , 18 , 19 , 20 , 21 , 22 , 23 , 24 , 25 , 26 , 27 , 28 , 29 , 30 , 31 };
            DayComboBox.ItemsSource = days;
            #endregion
            #region NUM Guest Combobox
            int[ ] numGuest = { 1 , 2 , 3 , 4 , 5 , 6 };
            GuestsNumCombobox.ItemsSource = numGuest;
            #endregion
            #region RoomTybe Combobox
            string[ ] RoomType = { " Single" , "Double" , "Twin" , "Duplex" , "Suite" };
            RoomTypeCombobox.ItemsSource = RoomType;
            #endregion
            #region FloorNum Combobox
            FloorCombobox.ItemsSource = new string[ ] { "1" , "2" , "3" , "4" , "5" };
            #endregion
            #region RoomNum Combobox
            NumCombobox.ItemsSource = new int[ ] {101,
        102,
        103,
        104,
        105,
        106,
        107,
        108,
        109,
        110,
        201,
        202,
        203,
        204,
        205,
        206,
        207,
        208,
        209,
        210,
        301,
        302,
        303,
        304,
        305,
        306,
        307,
        308,
        309,
        310,
        401,
        402,
        403,
        404,
        405,
        406,
        407,
        408,
        409,
        410,
        501,
        502,
        503,
        504,
        505,
        506,
        507,
        508,
        509,
        510};
            #endregion
            await controller.CloseAsync( );
        }

    }
}
