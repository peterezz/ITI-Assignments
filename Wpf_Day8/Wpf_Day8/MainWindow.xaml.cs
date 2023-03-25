using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Wpf_Day8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SaveChanges(object sender, RoutedEventArgs e)
        {
            Dictionary<string,string> Data = new Dictionary<string,string>()
            {
                { "First name", TxtFirstName.Text},
                {"Last name",TxtLastName.Text },
                {"Gender",TxtGender.Text },
                {"Address",TxtAddress.Text },
                {"Phone" , TxtPhone.Text },
                {"Mobile", TxtMobile.Text },
                {"Email", TxtEmail.Text },
                {"Job title", TxtJobTitle.Text },
            };
            string messageBoxText = String.Join('\n', Data.Select(keyValue=>$"{keyValue.Key}= {keyValue.Value}"));
            MessageBoxResult result;

            result = MessageBox.Show(messageBoxText, "Data", MessageBoxButton.OKCancel, MessageBoxImage.Information, MessageBoxResult.OK);
            if (result == MessageBoxResult.OK)
                result = MessageBox.Show("Data saved successfully", "Saving", MessageBoxButton.OK, MessageBoxImage.Information, MessageBoxResult.OK);

        }

        private void CloseWindow(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
