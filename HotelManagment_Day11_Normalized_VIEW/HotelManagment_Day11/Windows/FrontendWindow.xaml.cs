using HotelManagment_Day11.FrontendWindowPages;
using MahApps.Metro.Controls;
using System.Windows.Media;


namespace HotelManagment_Day11
{
    /// <summary>
    /// Interaction logic for Frontend.xaml
    /// </summary>
    public partial class Frontend : MetroWindow
    {
        public Frontend( )
        {
            InitializeComponent( );
        }

        private void LoadReservationPage( object sender , System.Windows.Input.MouseButtonEventArgs e )
        {
            ReservationLbl.Foreground = Brushes.Blue;
            UniversalLbl.Foreground = Brushes.White;
            AdvLbl.Foreground = Brushes.White;
            RoomLbl.Foreground = Brushes.White;
            LoadReservationPage( );
        }

        private void LoadReservationPage( object sender , System.EventArgs e )
        {
            LoadReservationPage( );
        }
        private void LoadReservationPage( )
        {
            MainFrame.Content = new ReservationPagePage( );
        }

        private void LoadRoomAvailibiltyPage( object sender , System.Windows.Input.MouseButtonEventArgs e )
        {
            ReservationLbl.Foreground = Brushes.White;
            AdvLbl.Foreground = Brushes.White;
            RoomLbl.Foreground = Brushes.Blue;
            UniversalLbl.Foreground = Brushes.White;
            MainFrame.Content = new RoomAvailibiltyPage( );
        }

        private void LoadReservationAdvViewPage( object sender , System.Windows.Input.MouseButtonEventArgs e )
        {
            ReservationLbl.Foreground = Brushes.White;
            AdvLbl.Foreground = Brushes.Blue;
            RoomLbl.Foreground = Brushes.White;
            UniversalLbl.Foreground = Brushes.White;
            MainFrame.Content = new ReservationAdvViewPage( );
        }

        private void LoadUniversalSearchPage( object sender , System.Windows.Input.MouseButtonEventArgs e )
        {
            ReservationLbl.Foreground = Brushes.White;
            AdvLbl.Foreground = Brushes.White;
            RoomLbl.Foreground = Brushes.White;
            UniversalLbl.Foreground = Brushes.Blue;
            MainFrame.Content = new UniversalSearchPage( );
        }
    }
}
