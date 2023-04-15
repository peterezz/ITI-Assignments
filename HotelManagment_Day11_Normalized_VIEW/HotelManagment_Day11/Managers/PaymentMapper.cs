using HotelManagment_Day11.Models;
using HotelManagment_Day11.ViewModels;

namespace HotelManagment_Day11.Managers
{
    public static class PaymentMapper
    {
        public static Payment ToPayment( this PaymentViewModel model )
        {
            return new( )
            {
                CardCVC = model.CardCVC ,
                CardExp = model.CardExp ,
                CardNumber = model.CardNumber ,
                CardType = model.CardType ,
                PaymentType = model.PaymentType ,
                TotalBill = model.TotalBill
            };
        }
    }
}
