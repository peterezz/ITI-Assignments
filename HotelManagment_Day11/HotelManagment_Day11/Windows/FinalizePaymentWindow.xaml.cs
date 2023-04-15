using HotelManagment_Day11.Managers;
using MahApps.Metro.Controls;

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
            ReservationPagePage.reservation.CardType = "MasterCard";
            DataContext = ReservationPagePage.reservation;
        }

        private async void btnNext_Click( object sender , System.Windows.RoutedEventArgs e )
        {

            ReservationPagePage.reservation.monthCardExpire = MonthComboBox.Text;
            ReservationPagePage.reservation.yearExpireDate = YearComboBox.Text;

            this.Close( );
        }

        private void LoadComboBoxes( object sender , System.Windows.RoutedEventArgs e )
        {
            #region PaymentMethod
            string[ ] PaymentType = { "Credit" , "Debit" };
            PaymentTypeComboBox.ItemsSource = PaymentType;
            #endregion
            #region Month Combobox
            string[ ] month = new string[ ] { "01" , "02" , "03" , "04" , "05" , "06" , "07" , "08" , "09" , "10" , "11" , "12" };
            MonthComboBox.ItemsSource = month;
            #endregion
            #region Year Combobox
            string[ ] years = { "18" , "19" , "20" , "21" , "22" , "23" , "24" , "25" , "26" , "27" , "28" , "29" , "30" , "31" };
            YearComboBox.ItemsSource = years;
            #endregion
        }
    }
}
