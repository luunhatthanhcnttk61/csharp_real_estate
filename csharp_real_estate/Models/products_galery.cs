//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace csharp_real_estate.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class products_galery
    {
        public int products_galery_id { get; set; }
        public int products_id { get; set; }
        public string img { get; set; }
    
        public virtual product product { get; set; }
        public virtual product product1 { get; set; }
        public virtual product product2 { get; set; }
    }
}
