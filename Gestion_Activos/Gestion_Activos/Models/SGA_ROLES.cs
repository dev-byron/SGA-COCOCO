//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Gestion_Activos.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class SGA_ROLES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SGA_ROLES()
        {
            this.SGA_ROLES_PERMISOS = new HashSet<SGA_ROLES_PERMISOS>();
            this.SGA_USUARIOS = new HashSet<SGA_USUARIOS>();
        }
    
        public int ID { get; set; }
        public string NOMBRE_ROL { get; set; }
        public Nullable<bool> PERMANENTE { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SGA_ROLES_PERMISOS> SGA_ROLES_PERMISOS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SGA_USUARIOS> SGA_USUARIOS { get; set; }
    }
}