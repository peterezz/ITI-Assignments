using HotelManagment_Day11.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelManagment_Day11.Configrations
{
    public class ReserverStateEntityTypeConfiguration : IEntityTypeConfiguration<ReserverState>
    {
        public void Configure( EntityTypeBuilder<ReserverState> builder )
        {

            builder.HasData( new ReserverState { Id = 1 , State = "Alabama" } );
            builder.HasData( new ReserverState { Id = 2 , State = "Alaska" } );
            builder.HasData( new ReserverState { Id = 3 , State = "Arizona" } );
            builder.HasData( new ReserverState { Id = 4 , State = "Arkansas" } );
            builder.HasData( new ReserverState { Id = 5 , State = "California" } );
            builder.HasData( new ReserverState { Id = 6 , State = "Colorado" } );
            builder.HasData( new ReserverState { Id = 7 , State = "Connecticut" } );
            builder.HasData( new ReserverState { Id = 8 , State = "Delaware" } );
            builder.HasData( new ReserverState { Id = 9 , State = "District Of Columbia" } );
            builder.HasData( new ReserverState { Id = 10 , State = "Florida" } );
            builder.HasData( new ReserverState { Id = 11 , State = "Georgia" } );
            builder.HasData( new ReserverState { Id = 12 , State = "Hawaii" } );
            builder.HasData( new ReserverState { Id = 13 , State = "Idaho" } );
            builder.HasData( new ReserverState { Id = 14 , State = "Illinois" } );
            builder.HasData( new ReserverState { Id = 15 , State = "Indiana" } );
            builder.HasData( new ReserverState { Id = 16 , State = "Iowa" } );
            builder.HasData( new ReserverState { Id = 17 , State = "Kansas" } );
            builder.HasData( new ReserverState { Id = 18 , State = "Kentucky" } );
            builder.HasData( new ReserverState { Id = 19 , State = "Louisiana" } );
            builder.HasData( new ReserverState { Id = 20 , State = "Maine" } );
            builder.HasData( new ReserverState { Id = 21 , State = "Maryland" } );
            builder.HasData( new ReserverState { Id = 22 , State = "Massachusetts" } );
            builder.HasData( new ReserverState { Id = 23 , State = "Michigan" } );
            builder.HasData( new ReserverState { Id = 24 , State = "Minnesota" } );
            builder.HasData( new ReserverState { Id = 25 , State = "Mississippi" } );
            builder.HasData( new ReserverState { Id = 26 , State = "Missouri" } );
            builder.HasData( new ReserverState { Id = 27 , State = "Montana" } );
            builder.HasData( new ReserverState { Id = 28 , State = "Nebraska" } );
            builder.HasData( new ReserverState { Id = 29 , State = "New Hampshire" } );
            builder.HasData( new ReserverState { Id = 30 , State = "New Jersey" } );
            builder.HasData( new ReserverState { Id = 31 , State = "New Mexico" } );
            builder.HasData( new ReserverState { Id = 32 , State = "New York" } );
        }
    }
}
