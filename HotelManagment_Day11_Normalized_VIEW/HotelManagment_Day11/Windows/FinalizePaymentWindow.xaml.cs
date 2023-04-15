using HotelManagment_Day11.Managers;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;

namespace HotelManagment_Day11.Windows
{
    /// <summary>
    /// Interaction logic for FinalizePaymentWindow.xaml
    /// </summary>
    public partial class FinalizePaymentWindow : MetroWindow
    {
        PaymentManager _paymentManager = new PaymentManager( );
        public FinalizePaymentWindow( )
        {
            InitializeComponent( );
            DataContext = ReservationPagePage.reservationViewModel.PaymentViewModel;
        }

        private async void btnNext_Click( object sender , System.Windows.RoutedEventArgs e )
        {
            if ( await _paymentManager.FinalizePaymentAsync( ) == 0 )
                await this.ShowMessageAsync( "Failed" , "Failed to save your payment method" );
            else
                this.Close( );
        }

        private void LoadComboBoxes( object sender , System.Windows.RoutedEventArgs e )
        {
            #region PaymentMethod
            string[ ] PaymentType = { "Credit" , "Debit" };
            PaymentTypeComboBox.ItemsSource = PaymentType;
            #endregion
            #region Month Combobox
            string[ ] month = new string[ ] { "January" , "February" , "March" , "April" , "May" , "June" , "July" , "August" , "September" , "October" , "November" , "December" };
            MonthComboBox.ItemsSource = month;
            #endregion
            #region Year Combobox
            int[ ] years = { 18 , 19 , 20 , 21 , 22 , 23 , 24 , 25 , 26 , 27 , 28 , 29 , 30 , 31 };
            YearComboBox.ItemsSource = years;
            #endregion
        }
    }
}
