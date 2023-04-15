using HotelManagment_Day11.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelManagment_Day11.Configrations
{
    public class ResrverGenderEntityTypeConfiguration : IEntityTypeConfiguration<ResrverGender>
    {
        public void Configure( EntityTypeBuilder<ResrverGender> builder )
        {
            builder.HasKey( x => x.Id );
            builder.HasData( new ResrverGender { Id = 1 , Gender = "Male" } );
            builder.HasData( new ResrverGender { Id = 2 , Gender = "Female" } );
            builder.HasData( new ResrverGender { Id = 3 , Gender = "Others" } );
        }
    }
}
