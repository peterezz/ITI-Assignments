using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day05
{
    internal class Club
    {
        public int ClubID { get; set; }
        public string ClubName { get; set; } = string.Empty;
        List<Empolyee> Members =new List<Empolyee>();
        public void AddMember(Empolyee member)
        {
            Members.Add(member);
            member.EmployeeLayOff += RemoveMember;
        }

        public void RemoveMember(object? sender, EmployeeLayOffEventArgs args)
        {
           if((sender is Empolyee emp) && (emp is not null) )
            {
                if (Members.Any(empolyee => empolyee.Name.ToLower().Equals(emp.Name)))
                {
                    Members.Remove(emp);
                    Console.WriteLine($"{emp.ToString()} \n \tis kicked out from \n\t{ToString()}" +
                         $"\n------------------------------------------------------------------------------------");
                }
            }
        }
        public override string ToString() => $"the Club which has ID: {ClubID} name: {ClubName}";
    }
}
