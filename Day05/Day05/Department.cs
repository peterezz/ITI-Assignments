using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day05
{
    internal class Department
    {
        public int DeptID { get; set; }
        public string DeptName { get; set; } = string.Empty;
        List<Empolyee> EmpolyeeList = new List<Empolyee>();
        public void AddStuff(Empolyee empolyee)
        {
            EmpolyeeList.Add(empolyee);
            empolyee.EmployeeLayOff += this.RemoveStuff;

        }
        public void RemoveStuff(Object Sender,EmployeeLayOffEventArgs args)
        {
            if ((Sender is Empolyee emp) && (emp is not null))
            {
                if (EmpolyeeList.Any(empolyee => empolyee.Name.ToLower().Equals(emp.Name, StringComparison.OrdinalIgnoreCase)))
                {
                    EmpolyeeList.Remove(emp);

                    Console.WriteLine($"{emp.ToString()} \n \tis fired because of {args.cause} from \n \t{ToString()}" +
                        $"\n------------------------------------------------------------------------------------");
                }
            }
        }
        public override string ToString() => $"the department which has ID: {DeptID} name: {DeptName}";

    }
}
