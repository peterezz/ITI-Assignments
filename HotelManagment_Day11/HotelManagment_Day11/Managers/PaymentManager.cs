namespace HotelManagment_Day11.Managers
{
    public class PaymentManager
    {
        public PaymentManager( )
        {
            FinlizePayment( );
        }
        public void FinlizePayment( )
        {
            var reservation = ReservationPagePage.reservation;
            ReservationPagePage.reservation.FoodBill = (reservation.BreakFast + reservation.Lunch + reservation.Dinner) * 18;
            ReservationPagePage.reservation.TotalBill = ReservationPagePage.reservation.FoodBill * 1.18;
            ReservationPagePage.reservation.TaxBill = ReservationPagePage.reservation.TotalBill - ReservationPagePage.reservation.FoodBill;
        }
    }
}
