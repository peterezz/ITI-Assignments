namespace HotelManagment_Day11.ViewModels
{
    public class PaymentViewModel
    {
        public int ID { get; set; }
        public decimal TotalBill { get { return ( decimal ) (( float ) FoodBill * 1.18); } }
        public string TotalBillText { get { return $"${TotalBill} USD"; } }
        public string TaxText
        {
            get
            {
                return $"${TotalBill - FoodBill} USD";
            }
        }
        public decimal FoodBill { get; set; }
        public string FoodBillText { get { return $"${FoodBill} USD"; } }
        public string PaymentType { get; set; }
        public int Year { get; set; }
        public string Month { get; set; } = string.Empty;
        public string CardType { get { return "MasterCard"; } }
        public string CardNumber { get; set; } = string.Empty;
        public string CardExp
        {
            get { return $"{Month}-{Year}"; }
        }
        public string CardCVC { get; set; } = string.Empty;
    }
}
