using HotelManagment_Day11.Models;
using System.Linq;
using System.Threading.Tasks;

namespace HotelManagment_Day11.Managers
{
    public class PaymentManager
    {
        HotelManagmentContext _Context = new HotelManagmentContext( );
        public PaymentManager( )
        {
            SetTotalBill( );
        }
        private void SetTotalBill( )
        {
            ReservationPagePage.reservationViewModel.PaymentViewModel.FoodBill = ( decimal ) (ReservationPagePage.reservationViewModel.Resrever_Service.Sum( prop => prop.Quantity * prop.Services.price ));
        }
        private async Task<int> CreatePaymentAsync( )
        {
            try
            {

                await _Context.AddAsync( ReservationPagePage.reservationViewModel.PaymentViewModel.ToPayment( ) );
                int x = await _Context.SaveChangesAsync( );
                ReservationPagePage.reservationViewModel.PaymentViewModel.ID = _Context.Payments.OrderByDescending( pay => pay.ID ).FirstOrDefault( )?.ID ?? 0;
                return x;
            }
            catch
            {
                return 0;
            }
        }

        // TODO : Update payment
        private async Task<int> UpdatePaymentAsync( int reserverID )
        {
            var olDdata = await _Context.Payments.FindAsync( reserverID );
            var newData = ReservationPagePage.reservationViewModel.PaymentViewModel;
            try
            {

                if ( olDdata != null )
                {
                    olDdata.TotalBill = newData.TotalBill;
                    olDdata.CardExp = newData.CardExp;
                    olDdata.CardCVC = newData.CardCVC;
                    olDdata.CardNumber = newData.CardNumber;
                    olDdata.CardType = newData.CardType;
                    olDdata.PaymentType = newData.PaymentType;
                }
                return await _Context.SaveChangesAsync( );
            }
            catch
            {
                return 0;
            }

        }

        public async Task<int> FinalizePaymentAsync( )
        {
            var reservation = ReservationPagePage.reservationViewModel;

            //{
            //    if ( !string.IsNullOrEmpty( reservation.PaymentViewModel.CardCVC ) || !string.IsNullOrEmpty( reservation.PaymentViewModel.CardNumber ) || reservation.PaymentViewModel.Year != 0 || !string.IsNullOrEmpty( reservation.PaymentViewModel.PaymentType ) )
            //    return 1;
            //}
            if ( reservation.Id == 0 )
                return await CreatePaymentAsync( );
            return await UpdatePaymentAsync( reservation.Id );
        }
        public async Task RemovePayment( int PaymentID )
        {
            var data = await _Context.Payments.FindAsync( PaymentID );
            if ( data != null )
            {
                _Context.Payments.Remove( data );
                await _Context.SaveChangesAsync( );
            }
        }
    }
}
