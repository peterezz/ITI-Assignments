namespace HotelManagment_Day11.ViewModels
{
    public class Resrever_ServiceViewModel
    {
        public int ReseverID { get; set; }
        public ServiceViewModel Services { get; set; } = new ServiceViewModel( );
        public int Quantity { get; set; }

        bool ischecked = false;
        public bool ISChecked
        {
            set
            {
                ischecked = value;
                Quantity = 1;
            }
            get
            {
                return ischecked;
            }
        }
    }
}
