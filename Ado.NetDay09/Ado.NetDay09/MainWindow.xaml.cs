using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows;
using static Ado.NetDay09.DatabaseHelper;

namespace Ado.NetDay09
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SqlCommand sqlCommand;
        SqlDataAdapter SqlDataAdapter;
        DataTable dataTable;
        public MainWindow( )
        {
            InitializeComponent( );
        }

        private void LoadTable( object sender , EventArgs e )
        {
            if ( sqlConnection.State == ConnectionState.Closed )
            {
                sqlCommand = new SqlCommand( "select * from Categories" , sqlConnection );
                SqlDataAdapter = new SqlDataAdapter( sqlCommand );
                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder( SqlDataAdapter );
                SqlDataAdapter.UpdateCommand = sqlCommandBuilder.GetUpdateCommand( );
                SqlDataAdapter.InsertCommand = sqlCommandBuilder.GetInsertCommand( );
                SqlDataAdapter.DeleteCommand = sqlCommandBuilder.GetDeleteCommand( );
                dataTable = new DataTable( );
                SqlDataAdapter.Fill( dataTable );
                dataGridView.ItemsSource = dataTable.AsDataView( );
                dataGridView.Columns.RemoveAt( 3 );
                dataGridView.Columns[ 0 ].IsReadOnly = true;
                dataGridView.Columns[ 2 ].Width = 450;

                sqlConnection.Close( );
            }

        }

        private void SaveChanges( object sender , RoutedEventArgs e )
        {
            SqlDataAdapter.Update( dataTable );
        }
    }
}
