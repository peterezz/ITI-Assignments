using Microsoft.Data.SqlClient;
using System.Data;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using static Ado.NetDay09.DatabaseHelper;

namespace Ado.NetDay09
{
    /// <summary>
    /// Interaction logic for Task02.xaml
    /// </summary>
    public partial class Task02 : Window
    {
        SqlDataAdapter sqlDataAdapter;
        DataTable dataTable;
        SqlCommand sqlCommand;
        public Task02( )
        {
            InitializeComponent( );
            sqlCommand = new SqlCommand( "select * from Products" , sqlConnection );
            sqlDataAdapter = new SqlDataAdapter( sqlCommand );



        }

        private void LoadPrdNames( object sender , System.EventArgs e )
        {
            dataTable = new DataTable( );
            sqlDataAdapter.Fill( dataTable );
            //ListPrds.ItemsSource = dataTable.AsEnumerable( ).Select( x => x.Field<string>( "ProductName" ) );
            ListPrds.ItemsSource = dataTable.AsDataView( );
            ListPrds.DisplayMemberPath = "ProductName";
            ListPrds.SelectedValuePath = "ProductID";
            ListPrds.SelectionChanged += ( sender , e ) => txtsPreview.DataContext = ListPrds.SelectedItem;
            txtPrdID.SetBinding( TextBox.TextProperty , new Binding( "ProductID" ) );
            txtPrdName.SetBinding( TextBox.TextProperty , new Binding( "ProductName" ) );
            txtUnitPrice.SetBinding( TextBox.TextProperty , new Binding( "UnitPrice" ) );
            ListPrds.DataContext = dataTable;




        }

        private void UpdateProduct( object sender , RoutedEventArgs e )
        {
            sqlDataAdapter.Update( dataTable );
            btnClearFields_Click( sender , e );
        }

        private void btnPreviousIndex_Click( object sender , RoutedEventArgs e )
        {
            if ( ListPrds.SelectedIndex != 0 )
            {
                --ListPrds.SelectedIndex;
            }
        }

        private void btnNextIndex_Click( object sender , RoutedEventArgs e )
        {
            if ( ListPrds.SelectedIndex != ListPrds.Items.Count - 1 )
            {
                ++ListPrds.SelectedIndex;
            }
        }

        private void btnPreviousLastIndex_Click( object sender , RoutedEventArgs e )
        {
            ListPrds.SelectedIndex = 0;
        }

        private void btnNextLastIndex_Click( object sender , RoutedEventArgs e )
        {
            ListPrds.SelectedIndex = ListPrds.Items.Count - 1;

        }

        private void AddNewProduct_Click( object sender , RoutedEventArgs e )
        {
            DataRow dataRow = dataTable.NewRow( );
            dataRow[ "ProductID" ] = txtPrdID.Text;
            dataRow[ "ProductName" ] = txtPrdName.Text;
            dataRow[ "UnitPrice" ] = txtUnitPrice.Text;
            dataTable.Rows.Add( dataRow );
            sqlDataAdapter.Update( dataTable );
            btnClearFields_Click( sender , e );

        }

        private void btnClearFields_Click( object sender , RoutedEventArgs e )
        {
            txtPrdID.Text = string.Empty;
            txtPrdName.Text = string.Empty;
            txtUnitPrice.Text = string.Empty;
        }
    }
}
