//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_role
    {
        public tbl_role()
        {
            this.parents = new HashSet<parent>();
            this.staffs = new HashSet<staff>();
            this.students = new HashSet<student>();
        }
    
        public int id { get; set; }
        public string RuleName { get; set; }
        public string status { get; set; }
    
        public virtual ICollection<parent> parents { get; set; }
        public virtual ICollection<staff> staffs { get; set; }
        public virtual ICollection<student> students { get; set; }
    }
}
