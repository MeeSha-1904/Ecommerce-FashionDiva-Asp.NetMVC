//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FHub.Models
{
    using System;
    
    public partial class sp_MasterValue_Select_Result
    {
        public int ID { get; set; }
        public int RefMasterId { get; set; }
        public string MasterName { get; set; }
        public Nullable<int> RefVendorId { get; set; }
        public string VendorName { get; set; }
        public string ValueName { get; set; }
        public string ValueDesc { get; set; }
        public Nullable<decimal> OrdNo { get; set; }
        public bool IsActive { get; set; }
        public int InsUser { get; set; }
        public System.DateTime InsDate { get; set; }
        public string InsTerminal { get; set; }
        public Nullable<int> UpdUser { get; set; }
        public Nullable<System.DateTime> UpdDate { get; set; }
        public string UpdTerminal { get; set; }
    }
}
