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
    
    public partial class news_comment
    {
        public int news_comment_id { get; set; }
        public int news_id { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public string message { get; set; }
    
        public virtual news news { get; set; }
        public virtual news news1 { get; set; }
        public virtual news news2 { get; set; }
    }
}
