//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVC_Day04.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Topic
    {
        public Topic()
        {
            this.Courses = new HashSet<Course>();
        }
    
        public int Top_Id { get; set; }
        public string Top_Name { get; set; }
    
        public virtual ICollection<Course> Courses { get; set; }
    }
}