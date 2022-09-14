using SistemaVenta.Core.Enumerations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SistemaVenta.Core.Entities
{
    [Table("Seguridad")]
    public class Seguridad: BaseEntity
    {
        [Key]
        public string Usuario { get; set; }
        public string NombreUsuario { get; set; }
        public string Contrasena { get; set; }
        public RoleType Rol { get; set; }
    }
}
