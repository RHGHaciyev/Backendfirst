//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BackendFinal.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class User_reg
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User_reg()
        {
            this.User_Type = new HashSet<User_Type>();
        }
    
        public int id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public int age { get; set; }
        public string email { get; set; }
        public Nullable<int> phone { get; set; }
        public string password { get; set; }
        public string User_ { get; set; }
        public Nullable<int> roleID { get; set; }
    
        public virtual User_rol User_rol { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<User_Type> User_Type { get; set; }
    }
}