//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KTSTRAVEL.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class image
    {
        public int imageId { get; set; }
        public Nullable<int> accommodationId { get; set; }
        public Nullable<int> tourId { get; set; }
        public Nullable<int> entertainmentId { get; set; }
        public string imagePath { get; set; }
        public Nullable<bool> status { get; set; }
        public Nullable<System.DateTime> dateEdited { get; set; }
        public Nullable<int> personId { get; set; }
    
        public virtual accommodation accommodation { get; set; }
        public virtual entertainment entertainment { get; set; }
        public virtual userAccount userAccount { get; set; }
        public virtual tour tour { get; set; }
    }
}
