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
    
    public partial class Blog_item_tofile
    {
        public int id { get; set; }
        public int blog_item_id { get; set; }
        public int files_id { get; set; }
    
        public virtual Blog_item Blog_item { get; set; }
        public virtual File File { get; set; }
    }
}
