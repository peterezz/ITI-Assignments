using System.Globalization;

namespace Day1
{
    internal class Employee : IComparable
    {
        private Gender _gender;
        private SecurityLevel _level;
        private string name=String.Empty;
        private string id=Guid.NewGuid().ToString();
        public HiringDate HiringDate { get; set; }
        public decimal Salary { get; set; }
        public bool SetGender(string gender)
        {
            if (Enum.IsDefined(typeof(Gender), gender))
            {
                _gender = (Gender)Enum.Parse(typeof(Gender), gender);
                return true;
            }
            return false;  
        }
        public string GetNationalityId() => this.id;
        public string Name
        {
            get { return this.name; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    this.name = value;
                else
                    this.name = "Emp Name is empty";
            }
        }
  
        public bool SetSecurityLevel(string securityLevel)
        {
            if(Enum.IsDefined(typeof(SecurityLevel), securityLevel))
            {
                _level = (SecurityLevel)Enum.Parse(typeof(SecurityLevel), securityLevel);
                return true;
            }
            return false;
        }
        public override string ToString()
        {
            return $"Empoloyee data:- Id: {id}, Name: {Name}, Gender: {_gender}," +
                $" Salary: {Salary.ToString("C", CultureInfo.CurrentCulture)}," +
                $" Security level: {_level},  {HiringDate.ToString()}. ";

        }
        public int CompareTo(object? obj)
        {

            Employee UserInput= obj as Employee;
            if (UserInput != null)
            {
                DateTime ThisDateTime;
                DateTime UserInputDateTime;
                string THString = this.HiringDate.GetDateTime();
                string UIHString = UserInput.HiringDate.GetDateTime();
                if ( DateTime.TryParse(THString, out ThisDateTime) &&
                    DateTime.TryParse(UIHString, out UserInputDateTime))
                    return ThisDateTime.CompareTo(UserInputDateTime);
            }
            return 0;

        }
    }
}
