using System.Data.Entity;

namespace MVC_Day5.Data
{
    public class MVC_Day05Context : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx

        public MVC_Day05Context( ) : base( "name=MVC_Day05Context" )
        {
        }

        public System.Data.Entity.DbSet<MVC_Day5.Models.Customer> Customers { get; set; }
        public System.Data.Entity.DbSet<MVC_Day5.Models.Order> Orders { get; set; }
    }
}
