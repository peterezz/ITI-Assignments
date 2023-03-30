using EntityFrameworkDay1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Windows;

namespace EntityFrameworkDay1
{
    /// <summary>
    /// Interaction logic for Task02.xaml
    /// </summary>
    public partial class Task02 : Window
    {
        pubsContext pubContext = new pubsContext();
        public Task02()
        {
            InitializeComponent();            
            pubContext.Publishers.Load();   
        }

        private void SaveChanges(object sender, RoutedEventArgs e)
        {
            pubContext.SaveChanges();
        }

        private void CloseConnection(object sender, EventArgs e)
        {
            pubContext.Dispose();
        }

        private void Relod(object sender, RoutedEventArgs e)
        {
            lstPublisherNames.ItemsSource = null;
            txtPubId.Text = "";
            txtCity.Text = "";
            txtPubName.Text = "";
            txtState.Text = "";
            txtCountry.Text = "";
            BindData(sender, e);
        }

        private void AddPublisher(object sender, RoutedEventArgs e)
        {
            pubContext.Add(new Publisher()
            {
                PubId = txtPubId.Text,
                City = txtCity.Text,
                State = txtState.Text,
                PubName = txtPubName.Text,
                Country = txtCountry.Text,
            });
            SaveChanges(sender, e);
        }

        private void BindData(object sender, EventArgs e)
        {
            lstPublisherNames.ItemsSource = pubContext.Publishers.Local.ToBindingList();
            lstPublisherNames.DisplayMemberPath = "PubName";
        }

        private void MainWindow(object sender, RoutedEventArgs e)
        {
            MainWindow x = new MainWindow();
            x.Show();
            this.Close();
        }
    }
}
