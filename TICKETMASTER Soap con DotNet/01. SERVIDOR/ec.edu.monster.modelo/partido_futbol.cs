//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _01.SERVIDOR.ec.edu.monster.modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class partido_futbol
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public partido_futbol()
        {
            this.localidad_partido = new HashSet<localidad_partido>();
        }
    
        public int PAR_ID { get; set; }
        public int EST_ID { get; set; }
        public int EQU_LOCAL { get; set; }
        public int EQU_VISITA { get; set; }
        public System.DateTime PAR_FECHA { get; set; }
        public System.DateTime PAR_HORA { get; set; }
    
        public virtual equipo equipo { get; set; }
        public virtual equipo equipo1 { get; set; }
        public virtual estadio estadio { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<localidad_partido> localidad_partido { get; set; }
    }
}