using EntityFrameworkDay1.Models;
using Microsoft.EntityFrameworkCore;
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

namespace EntityFrameworkDay1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        pubsContext pubContext= new pubsContext();
        public MainWindow()
        {
            InitializeComponent();


        }

        private void BindData(object sender, EventArgs e)
        {
            LoadData();
        }

        private void SaveChanges(object sender, RoutedEventArgs e)
        {
            dataGrid1.CommitEdit();
            pubContext.SaveChanges();
        }

        private void CloseConnection(object sender, EventArgs e)
        {
            pubContext.Dispose();
        }

        private void ReloadData(object sender, RoutedEventArgs e)
        {
            dataGrid1.ItemsSource = null;
          LoadData();

        }
        private void LoadData()
        {
            pubContext.Publishers.Load();
            pubContext.Titles.Load();
            dataGrid1.ItemsSource = pubContext.Titles.Local.ToBindingList();
            DataGridComboBoxColumn publishersComboBoxColumn = new DataGridComboBoxColumn()
            {
                ItemsSource = pubContext.Publishers.Local.ToBindingList(),
                SelectedValueBinding = new Binding("PubId"),
                Header = "publishers",
                Width = 200,
                DisplayMemberPath = "PubName",
                SelectedValuePath = "PubId"
            };

            dataGrid1.Columns[0].IsReadOnly = true;
            dataGrid1.Columns.RemoveAt(dataGrid1.Columns.Count - 1);
            dataGrid1.Columns.RemoveAt(dataGrid1.Columns.Count - 1);
            dataGrid1.Columns.RemoveAt(dataGrid1.Columns.Count - 1);
            dataGrid1.Columns.RemoveAt(3);
            dataGrid1.Columns.Add(publishersComboBoxColumn);
        }
    }
}
