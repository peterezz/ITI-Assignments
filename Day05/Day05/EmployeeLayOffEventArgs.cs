using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day05
{
    internal class EmployeeLayOffEventArgs : EventArgs
    {
        public LayOffCause cause { get; set; }
    }
}
