using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day05
{
    internal class Empolyee
    {

        public string Name { get; set; } = string.Empty;
        public DateTime BirthDate { get; set; }
        public int VacationStock { get; private set; } = 21;
        public event EventHandler<EmployeeLayOffEventArgs> EmployeeLayOff;
        protected virtual void OnEmployeeLayOff(EmployeeLayOffEventArgs eventArgs)=>
            EmployeeLayOff?.Invoke(this, eventArgs);
        public bool RequestVacation(DateTime from, DateTime to)/* =>*/
        //(to - from).Days < VacationStock; 
        {
            int vacationInterval = (to - from).Days;
                VacationStock -= vacationInterval;
            if ( VacationStock > 0)
                return true;
            OnEmployeeLayOff(new() { cause = LayOffCause.OutOffStock });
            return false;
        }
        public void EndOfYearOperation() {
           if( (DateTime.Now.Year - BirthDate.Year) > 60)
                OnEmployeeLayOff(new() { cause = LayOffCause.RetirementAge });
        }
        public override string ToString() => $"Empolyee whose name is {Name} and birthday is {BirthDate} ";



    }
}
