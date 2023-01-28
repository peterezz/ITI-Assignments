using Day4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    public class Employee
    {
        private int id;
        private string name="";
        private decimal salary;


        public HiringDate HiringDate { get; set; }
        public SecurityLevel SecurityLevel{ get; set; }
        public Gender Gender { get; set; }
        public int ID
        {
            get { 
                
                return this.id; }
            set
            {
                if (value > 0)
                    this.id = value;
            }
        }
        public string Name { get { return this.name; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    this.name = value;
                else
                    this.name = "Emp Name is empty";
            }
        }
        public decimal Salary
        {
            get { return salary; }
            set
            {
                if (value >= 2000 )
                    salary = value;
                else
                    salary = 2500;
            }
        }



        public string GetEmpData()
        {
            return $"ID: {this.ID} - Name: {Name} - Gender {Gender} - Salary:{Salary} - Security Level: {SecurityLevel} -  {HiringDate.GetHiringDate()}";

        }
    }
    public struct HiringDate
    {
        private string Day="";
        private string Month="";
        private string Year = "";
        public HiringDate(string Date)
        {
            string[] date = Date.Split('-');
            if (date.Length == 3)
            {
                int day, month, year;
                if (int.TryParse(date[0], out day) && int.TryParse(date[1], out month) && int.TryParse(date[2], out year))
                {
                    if (day >= 1 && day <= 31)
                        this.Day = date[0];
                    if (month >= 1 && month <= 12)
                        this.Month = date[1];
                    if (year >= 1999)
                        this.Year = date[2];
                }
            }
        }



        public string GetHiringYear()
        {
            return this.Year;
        }
        public string GetHiringMonth()
        {
            return this.Month;
        }
        public string GetHiringDay()
        {
            return this.Day;
        }
        public string GetHiringDate()
        {
            if (string.IsNullOrEmpty(this.Day) ||string.IsNullOrEmpty( this.Month )|| string.IsNullOrEmpty( this.Year))
                return "";
            return $"Hiring Date: {GetHiringDay()}, {GetHiringMonth()} - {GetHiringYear()}";
        }

    }
}
