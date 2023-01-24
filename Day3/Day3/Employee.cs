using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    public struct Employee
    {
        public int ID;
        public string Name;
        public float salary;
        public string ShowData()
        {
            return $"Employee id: {ID}, Emplyee Name: {Name}, Employee Salary: {salary} ";
        }
    }
}
