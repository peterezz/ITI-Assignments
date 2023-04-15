using HotelManagment_Day11.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelManagment_Day11.Configrations
{
    class UserEntityTypeConfigration : IEntityTypeConfiguration<User>
    {
        public void Configure( EntityTypeBuilder<User> builder )
        {
            builder.HasKey( user => user.user_name );
            builder.Property( user => user.user_name ).HasMaxLength( 50 );
            builder.Property( user => user.pass_word ).HasMaxLength( 50 );
            builder.HasData( new User { user_name = "admin" , pass_word = "admin" , Role = Roles.admin } );
            builder.HasData( new User { user_name = "ceaser.krit" , pass_word = "admin123" , Role = Roles.admin } );
            builder.HasData( new User { user_name = "nazim.amin" , pass_word = "admin" , Role = Roles.admin } );
            builder.HasData( new User { user_name = "kitchen" , pass_word = "kitchen" , Role = Roles.kitchen } );
            builder.HasData( new User { user_name = "_kitchen" , pass_word = "kitchen_" , Role = Roles.kitchen } );
        }
    }
}
