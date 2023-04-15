using HotelManagment_Day11.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelManagment_Day11.Configrations
{
    internal class ReserverChoicesEtityTypeConfiguration : IEntityTypeConfiguration<ReserverChoices>
    {
        public void Configure( EntityTypeBuilder<ReserverChoices> builder )
        {
            //builder.Property( prop => prop.room_type ).HasColumnType( "nchar(10)" );
            //builder.Property( prop => prop.room_floor ).HasColumnType( "nchar(10)" );
            //builder.Property( prop => prop.room_number ).HasColumnType( "nchar(10)" );
            builder.HasOne( choice => choice.Reserver ).WithMany( Reserver => Reserver.choices ).HasForeignKey( prop => prop.resrver_id );
        }
    }
}
