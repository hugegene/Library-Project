//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApplication12
{
    using System;
    using System.Collections.Generic;
    
    public partial class LibraryMember
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LibraryMember()
        {
            this.DueTrans = new HashSet<DueTran>();
            this.IssueTrans = new HashSet<IssueTran>();
        }
    
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public short Age { get; set; }
        public string Address { get; set; }
        public string PostalCode { get; set; }
        public string DocumentNo { get; set; }
        public string DocumentType { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public string AltPhoneNumber { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DueTran> DueTrans { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IssueTran> IssueTrans { get; set; }
    }
}
