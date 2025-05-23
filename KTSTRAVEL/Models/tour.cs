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
    
    public partial class tour
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tour()
        {
            this.images = new HashSet<image>();
            this.reviews = new HashSet<review>();
            this.tourBookings = new HashSet<tourBooking>();
            this.tourSchedules = new HashSet<tourSchedule>();
        }
    
        public int tourId { get; set; }
        public string tourName { get; set; }
        public string description { get; set; }
        public string departureLocation { get; set; }
        public Nullable<decimal> price { get; set; }
        public Nullable<System.DateTime> createdAt { get; set; }
        public Nullable<bool> status { get; set; }
        public Nullable<System.DateTime> dateEdited { get; set; }
        public Nullable<int> personId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<image> images { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<review> reviews { get; set; }
        public virtual userAccount userAccount { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tourBooking> tourBookings { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tourSchedule> tourSchedules { get; set; }
    }
}
