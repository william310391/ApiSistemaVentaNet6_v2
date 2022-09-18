using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaVenta.Core.Entities
{
    [Table("Producto")]
    public partial class Producto: BaseEntity
    {
  
        public Producto()
        {
            PedidoDetalle = new HashSet<PedidoDetalle>();
        }
        public string CodigoProducto { get; set; }
        public string NombreProducto { get; set; }
        public string Descripcion { get; set; }
        public string Imagen { get; set; }

        public virtual ICollection<PedidoDetalle> PedidoDetalle { get; set; }
    }
}
