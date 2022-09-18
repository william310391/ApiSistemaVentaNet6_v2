using Dapper.FluentMap.Dommel.Mapping;
using SistemaVenta.Core.Entities;

namespace SistemaVenta.Infrestructuras.Data.Configuration
{
    public class PedidoDetalleMap : DommelEntityMap<PedidoDetalle>
    {
        public PedidoDetalleMap()
        {
            ToTable("PedidoDetalle");
            Map(x => x.Id).ToColumn("IdPedidoDetalle").IsKey().IsIdentity();

            Map(x => x.IdPedido).ToColumn("IdPedido");
            Map(x => x.IdProducto).ToColumn("IdProducto");
            Map(x => x.Cantidad).ToColumn("Cantidad");
            Map(x => x.MontoUnitario).ToColumn("MontoUnitario");
            Map(x => x.MontoSubTotal).ToColumn("MontoSubTotal");
            Map(x => x.MontoIGV).ToColumn("MontoIGV");
            Map(x => x.MontoTotal).ToColumn("MontoTotal");
            Map(x => x.IndActivo).ToColumn("IndActivo");
            Map(x => x.IdUsuarioRegistro).ToColumn("IdUsuarioRegistro");
            Map(x => x.FechaRegistro).ToColumn("FechaRegistro");
            Map(x => x.IdUsuarioModificacion).ToColumn("IdUsuarioModificacion");
            Map(x => x.FechaModificacion).ToColumn("FechaModificacion");



        }
    }
}
