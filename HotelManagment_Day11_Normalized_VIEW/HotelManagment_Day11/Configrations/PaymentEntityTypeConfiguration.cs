using HotelManagment_Day11.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelManagment_Day11.Configrations
{
    public class PaymentEntityTypeConfiguration : IEntityTypeConfiguration<Payment>
    {
        public void Configure( EntityTypeBuilder<Payment> builder )
        {
            builder.HasKey( x => x.ID );
            builder.Property( prop => prop.CardCVC ).HasColumnType( "nchar(10)" );
            builder.Property( prop => prop.PaymentType ).HasColumnType( "nchar(10)" );
            builder.Property( prop => prop.CardType ).HasColumnType( "nchar(10)" );
            builder.Property( prop => prop.CardExp ).HasMaxLength( 50 );
            builder.Property( prop => prop.CardNumber ).HasMaxLength( 50 );
            builder.HasOne( prop => prop.Reserver ).WithOne( prop => prop.payment ).HasForeignKey<Reserver>( prop => prop.PaymentID );
        }
    }
}
