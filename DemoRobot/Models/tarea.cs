//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DemoRobot.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tarea
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tarea()
        {
            this.horario = new HashSet<horario>();
        }
    
        public int id_tarea { get; set; }
        public string nombre_tarea { get; set; }
        public int id_robot { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<horario> horario { get; set; }
        public virtual robot robot { get; set; }
        public virtual robot robot1 { get; set; }
    }
}
