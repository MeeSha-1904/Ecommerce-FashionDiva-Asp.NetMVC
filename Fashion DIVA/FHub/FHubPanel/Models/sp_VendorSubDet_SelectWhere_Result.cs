//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FHubPanel.Models
{
    using System;
    
    public partial class sp_VendorSubDet_SelectWhere_Result
    {
        public int VendorSubId { get; set; }
        public int RefSubId { get; set; }
        public int RefVendorId { get; set; }
        public Nullable<System.DateTime> ValidFromDate { get; set; }
        public Nullable<System.DateTime> ValidTodate { get; set; }
        public int InsUser { get; set; }
        public System.DateTime InsDate { get; set; }
        public string InsTerminal { get; set; }
        public Nullable<int> UpdUser { get; set; }
        public Nullable<System.DateTime> UpdDate { get; set; }
        public string UpdTerminal { get; set; }
        public Nullable<int> NoOfAppUser { get; set; }
        public Nullable<int> NoOfDays { get; set; }
        public Nullable<int> NoOfProducts { get; set; }
        public Nullable<int> NoOfSlider { get; set; }
        public string SubType { get; set; }
        public string UserName { get; set; }
        public string VendorName { get; set; }
    }
}