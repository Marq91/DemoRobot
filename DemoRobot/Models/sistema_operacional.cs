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
    
    public partial class sistema_operacional
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public sistema_operacional()
        {
            this.sys_robot = new HashSet<sys_robot>();
            this.sys_robot1 = new HashSet<sys_robot>();
        }
    
        public int id_sistema { get; set; }
        public string nombre_sis { get; set; }
        public string version { get; set; }
        public string credenciales { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<sys_robot> sys_robot { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<sys_robot> sys_robot1 { get; set; }
    }
}