//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ContactManagementApp.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class NoteType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NoteType()
        {
            this.ContractNotes = new HashSet<ContractNote>();
        }
    
        public int Id { get; set; }
        public string NoteTypeName { get; set; }
        public string NoteTypeDesc { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContractNote> ContractNotes { get; set; }
    }
}
