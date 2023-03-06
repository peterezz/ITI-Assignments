using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    internal class EmpListIndexer
    {
        public Employee[] ListEmps { get; set; }
        //TODO : Search Emp
        public EmpListIndexer(Employee[] emp)
        {
            ListEmps = emp;
        }

        public Employee this[string searchVal]
        {
            get
            {
                foreach (Employee emp in ListEmps)
                {
                    if(emp.GetNationalityId().Equals(searchVal) ||
                       emp.Name.Equals(searchVal))
                        return emp;
                }
                return null;
            }
        }
        public Employee this[HiringDate hiringDate]
        {
            get
            {
                foreach(Employee emp in ListEmps)
                {
                    if(emp.HiringDate.ToString().Equals(hiringDate.ToString()))
                        return emp;
                }
                return null;
            }
        }


    }
}
