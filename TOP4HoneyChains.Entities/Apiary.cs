//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TOP4HoneyChains.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Apiary
    {
        public int ApiaryId { get; set; }
        public Nullable<System.Guid> BeekeeperId { get; set; }
        public string ApiaryIdentityNumber { get; set; }
        public string ApiaryTitle { get; set; }
        public short NumberOfBeehives { get; set; }
        public Nullable<decimal> LocationLatitude { get; set; }
        public Nullable<decimal> LocationLongitude { get; set; }
        public Nullable<int> LocationType { get; set; }
    }
}
