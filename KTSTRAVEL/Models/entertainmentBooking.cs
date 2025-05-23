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
    
    public partial class entertainmentBooking
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public entertainmentBooking()
        {
            this.invoices = new HashSet<invoice>();
        }
    
        public int entertainmentBookingId { get; set; }
        public int userId { get; set; }
        public int entertainmentId { get; set; }
        public System.DateTime bookingDate { get; set; }
        public System.DateTime departureDate { get; set; }
        public Nullable<int> quantity { get; set; }
        public Nullable<decimal> totalPrice { get; set; }
        public string status { get; set; }
        public Nullable<System.DateTime> createdAt { get; set; }
        public Nullable<System.DateTime> dateEdited { get; set; }
        public Nullable<int> personId { get; set; }
    
        public virtual entertainment entertainment { get; set; }
        public virtual userAccount userAccount { get; set; }
        public virtual userAccount userAccount1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<invoice> invoices { get; set; }
    }
}
