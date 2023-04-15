using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelManagment_Day11.Models
{
    public partial class Reservation
    {
        [NotMapped]
        [Required]
        public string month
        {
            get
            {
                if ( string.IsNullOrEmpty( BirthDay ) ) return string.Empty;
                return BirthDay.Split( ' ' )[ 0 ];
            }
            set { BirthDay = $"{value}-"; }
        }
        [NotMapped]
        [Required]
        public int day
        {
            get
            {
                if ( string.IsNullOrEmpty( BirthDay ) ) return 0;
                return int.Parse( BirthDay.Split( '-' )[ 1 ] );
            }
            set { BirthDay = $"{BirthDay}{value}-"; }
        }
        [NotMapped]
        [Required]
        public string year
        {
            get
            {
                if ( string.IsNullOrEmpty( BirthDay ) ) return string.Empty;
                return BirthDay.Split( '-' )[ 2 ];
            }
            set { BirthDay = $"{BirthDay}{value}"; }
        }
        [NotMapped]
        public string DisplayedMember
        {
            get
            {
                if ( Id == 0 )
                    return string.Empty;
                return $"{Id} | {FirstName} {LastName} | {PhoneNumber}";
            }
        }
        private bool breakfastCheckBox;
        [NotMapped]
        public bool BreakfastCheckBox
        {
            get
            {

                if ( BreakFast > 0 )
                    breakfastCheckBox = true;
                return breakfastCheckBox;

            }
            set { breakfastCheckBox = value; }
        }
        private bool dinnerCheckBox;
        [NotMapped]
        public bool DinnerCheckBox
        {
            get
            {

                if ( Dinner > 0 )
                    dinnerCheckBox = true;
                return dinnerCheckBox;

            }
            set { dinnerCheckBox = value; }
        }
        private bool lunchCheckbox;
        [NotMapped]
        public bool LunchCheckbox
        {
            get
            {

                if ( Lunch > 0 )
                    lunchCheckbox = true;
                return lunchCheckbox;

            }
            set { lunchCheckbox = value; }
        }
        [NotMapped]
        public double TaxBill { get; set; }
        [NotMapped]
        public string TaxString { get { return $"${TaxBill} USD"; } }
        [NotMapped]
        public double OldBill { get { return TotalBill; } }
        [NotMapped]
        public string OldBillString { get { return $"${OldBill} USD"; } }
        [NotMapped]
        public string FoodBillText { get { return $"${FoodBill} USD"; } }
        [NotMapped]
        public string TotalBillString { get { return $"${TotalBill} USD"; } }

        [NotMapped]
        public string monthCardExpire
        {
            get
            {
                if ( string.IsNullOrEmpty( CardExp ) ) return string.Empty;
                return CardExp.Split( '/' )[ 0 ];
            }
            set { CardExp = $"{value}/"; }
        }
        [NotMapped]
        public string yearExpireDate
        {
            get
            {
                if ( string.IsNullOrEmpty( CardExp ) ) return string.Empty;
                return CardExp.Split( '/' )[ 1 ];
            }
            set { CardExp = $"{CardExp}{value}"; }
        }
    }
}
