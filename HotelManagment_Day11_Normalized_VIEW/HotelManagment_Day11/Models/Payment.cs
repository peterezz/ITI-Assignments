namespace HotelManagment_Day11.Models
{
    public class Payment
    {
        public int ID { get; set; }
        public decimal TotalBill { get; set; }
        public string PaymentType { get; set; } = string.Empty;
        public string CardType { get; set; } = string.Empty;
        public string CardNumber { get; set; } = string.Empty;
        public string CardExp { get; set; } = string.Empty;
        public string CardCVC { get; set; } = string.Empty;
        public Reserver? Reserver { get; set; } = default;

    }
}
