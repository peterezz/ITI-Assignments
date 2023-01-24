using System;

namespace Day4
{
    public struct Employee
    {
        private int ID;
        private string Name;
        private decimal Salary;
        private SecurityLevel SecurityLevel;
        private Gender Gender;
        private HiringDate hiringDate;
        public Employee(int id, string name,decimal salary,SecurityLevel securityLevel,Gender gender,HiringDate hiringDate)
        {
            this.SecurityLevel = securityLevel;
            this.Salary = salary;
            this.Name = name;
            this.Gender = gender;
            this.ID = id;
            this.hiringDate = hiringDate;

        }
        public void SetEmpId(int id)
        {
            if(id>0)
                this.ID = id;
        }
        public void SetEmpName(string empName)
        {
            if (!string.IsNullOrEmpty(empName))
                this.Name = empName;
            else
                this.Name = "N/A";
        }
        public void SetEmpSalary(decimal empSalary)
        {
            if (empSalary >= 2500 && empSalary <= 5000)
                this.Salary = empSalary;
            else
                this.Salary = 2500;
        }
        public void SetEmpSecurityLevel(SecurityLevel securityLevel)
        {
            this.SecurityLevel = securityLevel;
        }
        public void SetHiringDate(string Date)
        {
            this.hiringDate.SetHiringDate(Date);
        }


        public string GetEmpDate()
        {
           return  $"ID: {this.ID} - Name: {this.Name} - Gender {this.Gender} - Salary:{this.Salary} - Security Level: {this.SecurityLevel} - Hiring date: {this.hiringDate.GetHiringDate()}";
        }

        public void SetEmpGender(Gender gender)
        {
            this.Gender = gender;
        }
    }
    public struct HiringDate
    {
        private string Day;
        private string Month;
        private string Year;
        public HiringDate(string day,string month,string year)
        {
            Day = day;
            Month = month;  
            Year = year;
        }
        public void SetHiringDate(string Date)
        {
            string[] date=Date.Split('-');
            if (date.Length == 3)
            {
                if (int.Parse(date[0])>=1 && int.Parse(date[0])<=30)
                     this.Day = date[0];
                if (int.Parse(date[1]) >= 1 && int.Parse(date[1]) <= 12)
                    this.Month = date[1];
                if (int.Parse(date[2]) >= 2020 )
                    this.Year = date[2];
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
            return $"Hiring Date: {GetHiringDay()}, {GetHiringMonth()} - {GetHiringYear()}";
        }

    }

}
