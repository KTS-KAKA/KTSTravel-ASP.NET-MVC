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
    
    public partial class entertainment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public entertainment()
        {
            this.entertainmentBookings = new HashSet<entertainmentBooking>();
            this.images = new HashSet<image>();
            this.reviews = new HashSet<review>();
            this.entertainmentServices = new HashSet<entertainmentService>();
        }
    
        public int entertainmentId { get; set; }
        public Nullable<int> entertainmentTypeId { get; set; }
        public string name { get; set; }
        public string Location { get; set; }
        public string image { get; set; }
        public Nullable<decimal> price { get; set; }
        public Nullable<System.TimeSpan> openTime { get; set; }
        public Nullable<System.TimeSpan> closeTime { get; set; }
        public Nullable<bool> status { get; set; }
        public Nullable<System.DateTime> dateEdited { get; set; }
        public Nullable<int> personId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<entertainmentBooking> entertainmentBookings { get; set; }
        public virtual entertainmentType entertainmentType { get; set; }
        public virtual userAccount userAccount { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<image> images { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<review> reviews { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<entertainmentService> entertainmentServices { get; set; }
    }
}
