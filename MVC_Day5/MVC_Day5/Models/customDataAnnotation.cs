using System.ComponentModel.DataAnnotations;

namespace MVC_Day5.Models
{
    public class CheckEqualityDataAnnotation : ValidationAttribute
    {
        int _totalPrice;
        public CheckEqualityDataAnnotation( int totalPrice )
        {
            _totalPrice = totalPrice;
        }

        public override bool IsValid( object value )
        {

            if ( value == null )
            {
                return false;
            }
            if ( value is int )
            {
                int suppliedVal = ( int ) value;
                if ( suppliedVal < _totalPrice )
                {
                    ErrorMessage = $"supplid value: {suppliedVal} is less than the spacfied value: {_totalPrice}";
                    return false;
                }
                else if ( suppliedVal > _totalPrice )
                {
                    ErrorMessage = $"supplid value: {suppliedVal} is more than the spacfied value: {_totalPrice}";
                    return false;
                }
                return true;
            }
            return false;
        }
    }
}