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
    using System.Collections.Generic;
    
    public partial class VendorSlider
    {
        public int SliderId { get; set; }
        public int RefVendorId { get; set; }
        public string SliderTitle { get; set; }
        public string SliderImg { get; set; }
        public string SliderUrl { get; set; }
        public Nullable<int> Ord { get; set; }
        public string DisplayPage { get; set; }
        public string Category { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public int InsUser { get; set; }
        public System.DateTime InsDate { get; set; }
        public string InsTerminal { get; set; }
        public Nullable<int> UpdUser { get; set; }
        public Nullable<System.DateTime> UpdDate { get; set; }
        public string UpdTerminal { get; set; }
    
        public virtual Vendor Vendor { get; set; }
    }
}
