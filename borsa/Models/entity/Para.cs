//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace borsa.Models.entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Para
    {
        public int ParaId { get; set; }
        public Nullable<int> KullaniciId { get; set; }
        public Nullable<decimal> ParaMiktar { get; set; }
        public Nullable<bool> ParaOnay { get; set; }
    
        public virtual Kullanicilar Kullanicilar { get; set; }
    }
}
