﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DemoRobotEntities : DbContext
    {
        public DemoRobotEntities()
            : base("name=DemoRobotEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<horario> horario { get; set; }
        public virtual DbSet<robot> robot { get; set; }
        public virtual DbSet<servidor> servidor { get; set; }
        public virtual DbSet<sistema_op_x_robot> sistema_op_x_robot { get; set; }
        public virtual DbSet<sistema_operacional> sistema_operacional { get; set; }
        public virtual DbSet<tarea> tarea { get; set; }
    }
}
