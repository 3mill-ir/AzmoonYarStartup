//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AzmoonYarWeb.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Mapping_Profile_Pasokh
    {
        public int Id { get; set; }
        public Nullable<int> F_PasokhId { get; set; }
        public Nullable<int> F_ProfileId { get; set; }
        public Nullable<System.DateTime> CreateDateOnUtc { get; set; }
        public Nullable<int> SoalId { get; set; }
    
        public virtual Pasokh Pasokh { get; set; }
        public virtual Profile Profile { get; set; }
    }
}