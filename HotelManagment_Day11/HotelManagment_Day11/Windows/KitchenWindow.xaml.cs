using HotelManagment_Day11.Pages.KitchenWindowPages;
using MahApps.Metro.Controls;
using System.Windows.Media;

namespace HotelManagment_Day11.Windows
{
    /// <summary>
    /// Interaction logic for KitchenWindow.xaml
    /// </summary>
    public partial class KitchenWindow : MetroWindow
    {
        public KitchenWindow( )
        {
            InitializeComponent( );
            LoadTODO_Page( );
        }

        private void LoadTODO_Page( object sender , System.Windows.Input.MouseButtonEventArgs e )
        {
            TodoLbl.Foreground = Brushes.Blue;
            OverviewLbl.Foreground = Brushes.White;
            LoadTODO_Page( );
        }
        private void LoadTODO_Page( )
        {
            MainFrame.Content = new TodoPage( );

        }

        private void LoadOverviewPage( object sender , System.Windows.Input.MouseButtonEventArgs e )
        {
            TodoLbl.Foreground = Brushes.White;
            OverviewLbl.Foreground = Brushes.Blue;
            MainFrame.Content = new OverviewPage( );
        }
    }
}
