using HotelManagment_Day11.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelManagment_Day11.Configrations
{
    public class MenuEntityTypeConfiguration : IEntityTypeConfiguration<Service>
    {
        public void Configure( EntityTypeBuilder<Service> builder )
        {
            builder.HasKey( x => x.Id );
            builder.Property( prop => prop.service ).HasMaxLength( 50 );
            builder.HasData( new Service( ) { Id = 1 , service = "break_fast" , price = 7 } );
            builder.HasData( new Service( ) { Id = 2 , service = "lunch" , price = 15 } );
            builder.HasData( new Service( ) { Id = 3 , service = "dinner" , price = 15 } );
            builder.HasData( new Service( ) { Id = 4 , service = "cleaning" , price = 20 } );
            builder.HasData( new Service( ) { Id = 5 , service = "towel" , price = 14 } );
            builder.HasData( new Service( ) { Id = 6 , service = "Sweetest Surprise" , price = 30 } );

        }
    }
    public class Reserver_MenuEntityTypeConfiguration : IEntityTypeConfiguration<Reserver_Service>
    {
        public void Configure( EntityTypeBuilder<Reserver_Service> builder )
        {
            builder.HasKey( x => new { x.ReserverID , x.ServiceID } );
            //builder.HasMany( model => model.Reservers ).WithMany( model => model.services );
            //builder.HasMany( model => model.Services ).WithMany( model => model.Reserver_Service );

        }
    }
}
