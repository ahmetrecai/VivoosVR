//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Core.Common.DataModel.Core
{
    
    using System.Runtime.Serialization;
    
    using System;
    using System.Collections.Generic;
    
    [DataContract(IsReference = true)]
    public partial class RoleToUserMap
    {
    	[DataMember]
        public System.Guid Id { get; set; }
    	[DataMember]
        public System.Guid UserId { get; set; }
    	[DataMember]
        public string RoleCode { get; set; }
    	[DataMember]
        public Nullable<System.DateTime> ValidUntil { get; set; }
    	[DataMember]
        public System.DateTime EntryDate { get; set; }
    	[DataMember]
        public bool Available { get; set; }
    
    	[DataMember]
        public virtual Role Role { get; set; }
    	[DataMember]
        public virtual User User { get; set; }
    }
}
