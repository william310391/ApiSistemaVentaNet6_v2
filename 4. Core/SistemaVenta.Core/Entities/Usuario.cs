using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaVenta.Core.Entities
{
    [Table("Persona")]
    public partial class Usuario : BaseEntity
    {
        [Key]
        public int IdUsuario { get; set; }
        public string Cuenta { get; set; }
        public string Contrasena { get; set; }
        public string NombreUsuario { get; set; }
        public int IdRol { get; set; }
    }
}
