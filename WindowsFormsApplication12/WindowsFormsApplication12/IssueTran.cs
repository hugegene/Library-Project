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
    
    public partial class IssueTran
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IssueTran()
        {
            this.BookIssueds = new HashSet<BookIssued>();
        }
    
        public int TransactionNo { get; set; }
        public int CustomerID { get; set; }
    
        public virtual LibraryMember LibraryMember { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BookIssued> BookIssueds { get; set; }
    }
}
