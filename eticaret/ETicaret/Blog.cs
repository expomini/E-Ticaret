//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ETicaret
{
    using System;
    using System.Collections.Generic;
    
    public partial class Blog
    {
        public int BlogID { get; set; }
        public Nullable<int> UrunID { get; set; }
        public string Baslik { get; set; }
        public string Metin { get; set; }
        public Nullable<System.DateTime> tarih { get; set; }
        public string BlogResim { get; set; }
    
        public virtual Urunler Urunler { get; set; }
    }
}
