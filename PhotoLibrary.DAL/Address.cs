//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PhotoLibrary.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Address
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string CityName { get; set; }
        public int UserId { get; set; }
        public Nullable<int> StateId { get; set; }
        public Nullable<int> ZIP { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public Nullable<System.DateTime> LastChanged { get; set; }
    
        public virtual User User { get; set; }
        public virtual State State { get; set; }
    }
}
