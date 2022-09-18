﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaVenta.Core.Entities
{
    [Table("Cliente")]
    public partial class Cliente: BaseEntity
    {
 
        public Cliente()
        {
            Pedido = new HashSet<Pedido>();
        }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApallidoMaterno { get; set; }
        public string RazonSocial { get; set; }
        public int? IdTipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public DateTime? FechaNacimiento { get; set; }

        public virtual ICollection<Pedido> Pedido { get; set; }
    }
}
