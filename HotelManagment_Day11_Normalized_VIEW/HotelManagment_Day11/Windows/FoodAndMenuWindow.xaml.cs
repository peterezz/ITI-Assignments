using HotelManagment_Day11.Managers;
using HotelManagment_Day11.ViewModels;
using MahApps.Metro.Controls;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace HotelManagment_Day11.Windows
{
    /// <summary>
    /// Interaction logic for FoodAndMenuWindow.xaml
    /// </summary>
    public partial class FoodAndMenuWindow : MetroWindow
    {
        Reserver_ServiceManager reserver_ServiceManager = new( );
        List<Resrever_ServiceViewModel> resrever_ServiceViewModels = new List<Resrever_ServiceViewModel>( );
        public FoodAndMenuWindow( )
        {
            InitializeComponent( );


        }
        private void btnNext_Click( object sender , RoutedEventArgs e )
        {
            ReservationPagePage.reservationViewModel.Resrever_Service = resrever_ServiceViewModels;
            this.Close( );
        }

        private async void LoadMenue( object sender , RoutedEventArgs e )
        {
            if ( ReservationPagePage.reservationViewModel.Id != 0 )
            {
                ReservationPagePage.reservationViewModel.Resrever_Service = await reserver_ServiceManager.SearchService( ReservationPagePage.reservationViewModel.Id );
            }
            resrever_ServiceViewModels = await reserver_ServiceManager.GetServices( );
            #region Load Services
            PanelBreafast.DataContext = resrever_ServiceViewModels.FirstOrDefault( model => model.Services.service.Equals( "break_fast" ) );
            PanelLunch.DataContext = resrever_ServiceViewModels.FirstOrDefault( model => model.Services.service.Equals( "lunch" ) );
            PanelDinner.DataContext = resrever_ServiceViewModels.FirstOrDefault( model => model.Services.service.Equals( "dinner" ) );
            CleaningCheckBox.DataContext = resrever_ServiceViewModels.FirstOrDefault( model => model.Services.service.Equals( "cleaning" ) );
            TowelsCheckBox.DataContext = resrever_ServiceViewModels.FirstOrDefault( model => model.Services.service.Equals( "towel" ) );
            SweetestSurpriseCheckBox.DataContext = resrever_ServiceViewModels.FirstOrDefault( model => model.Services.service.Equals( "Sweetest Surprise" ) );
            #endregion


        }


    }
}
