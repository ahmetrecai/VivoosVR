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
    public partial class ConsumerPropertyType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ConsumerPropertyType()
        {
            this.ConsumerProperties = new HashSet<ConsumerProperty>();
        }
    
    	[DataMember]
        public int No { get; set; }
    	[DataMember]
        public string Name { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    	[DataMember]
        public virtual ICollection<ConsumerProperty> ConsumerProperties { get; set; }
    }
}
