using HotelManagment_Day11.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelManagment_Day11.Configrations
{
    internal class ReserverEntityTypeConfigration : IEntityTypeConfiguration<Reserver>
    {
        public void Configure( EntityTypeBuilder<Reserver> builder )
        {
            builder.HasKey( x => x.Id );
            builder.Property( prop => prop.first_name ).HasMaxLength( 50 );
            builder.Property( prop => prop.last_name ).HasMaxLength( 50 );
            builder.Property( prop => prop.birth_day ).HasMaxLength( 50 );
            builder.Property( prop => prop.phone_number ).HasMaxLength( 50 );
            builder.Property( prop => prop.apt_suite ).HasMaxLength( 50 );
            builder.Property( prop => prop.zip_code ).HasColumnType( "nchar(10)" );
            builder.HasOne( reserver => reserver.gender ).WithMany( gender => gender.Reservers ).HasForeignKey( prop => prop.gender_id );
            builder.HasOne( reserver => reserver.state ).WithMany( state => state.Reservers ).HasForeignKey( prop => prop.state_id );

        }
    }
}
