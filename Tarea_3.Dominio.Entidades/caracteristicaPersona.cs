//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tarea_3.Dominio.Entidades
{
    using System;
    using System.Collections.Generic;
    
    public partial class caracteristicaPersona
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public caracteristicaPersona()
        {
            this.persona = new HashSet<persona>();
        }
    
        public int idCaracteristica { get; set; }
        public int forma { get; set; }
        public int tamanio { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<persona> persona { get; set; }
    }
}
