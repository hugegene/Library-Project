//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Library
{
    using System;
    using System.Collections.Generic;
    
    public partial class BookIssued
    {
        public int TransactionNo { get; set; }
        public string ISBN { get; set; }
        public string BookTitle { get; set; }
        public System.DateTime DateBorrow { get; set; }
        public System.DateTime DateDue { get; set; }
        public Nullable<System.DateTime> DateActualReturn { get; set; }
    
        public virtual BookList BookList { get; set; }
        public virtual IssueTran IssueTran { get; set; }
    }
}
