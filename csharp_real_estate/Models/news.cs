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
    
    public partial class news
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public news()
        {
            this.news_comment = new HashSet<news_comment>();
            this.news_comment1 = new HashSet<news_comment>();
            this.news_comment2 = new HashSet<news_comment>();
        }
    
        public int news_id { get; set; }
        public string news_name { get; set; }
        public string news_slug { get; set; }
        public string content { get; set; }
        public string thumbnail { get; set; }
        public System.DateTime postdate { get; set; }
        public int viewCount { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<news_comment> news_comment { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<news_comment> news_comment1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<news_comment> news_comment2 { get; set; }
    }
}
