namespace HotelManagment_Day11.Models
{
    public enum Roles
    {
        admin,
        kitchen,
        NotFound
    }
    public class User
    {

        public string user_name { get; set; } = string.Empty;
        public string pass_word { get; set; } = string.Empty;
        public Roles Role { get; set; }

    }
}
