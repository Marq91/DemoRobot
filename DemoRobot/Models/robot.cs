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
    
    public partial class robot
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public robot()
        {
            this.sistema_op_x_robot = new HashSet<sistema_op_x_robot>();
            this.tarea = new HashSet<tarea>();
        }
    
        public int id_robot { get; set; }
        public string nombre_robot { get; set; }
        public string estado { get; set; }
        public int id_servidor { get; set; }
    
        public virtual servidor servidor { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<sistema_op_x_robot> sistema_op_x_robot { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tarea> tarea { get; set; }
    }
}
