using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaVenta.Core.Entities
{
    [Table("PedidoDetalle")]
    public partial class PedidoDetalle: BaseEntity
    {
        public int? IdPedido { get; set; }
        public int? IdProducto { get; set; }
        public int? Cantidad { get; set; }
        public decimal? MontoUnitario { get; set; }
        public decimal? MontoSubTotal { get; set; }
        public decimal? MontoIGV { get; set; }
        public decimal? MontoTotal { get; set; }

        public virtual Pedido Pedido { get; set; }
        public virtual Producto Producto { get; set; }
    }
}
