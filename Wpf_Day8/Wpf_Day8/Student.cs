using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_Day8
{
    class Student
    {
        public int Id { get; set; }
        public int age { get; set; }
        public string Name { get; set; } = string.Empty;
        public float Grade { get; set; }
        public string Image{ get; set; }         

        public Student(int id, int age, string name, float grade, string image)
        {
            Id = id;
            this.age = age;
            Name = name;
            Grade = grade;
            Image = image;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
