//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CuyStore.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CuentaUsuario
    {
        public int CuentaUsuarioId { get; set; }
        public int ClienteId { get; set; }
        public string Usuario { get; set; }
        public string Contraseña { get; set; }
        public System.DateTime FechaRegistro { get; set; }
        public bool Estado { get; set; }
    
        public virtual Cliente Cliente { get; set; }
    }
}