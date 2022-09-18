using Dapper.FluentMap.Dommel.Mapping;
using SistemaVenta.Core.Entities;

namespace SistemaVenta.Infrestructuras.Data.Configuration
{
    public class PedidoMap: DommelEntityMap<Pedido>
    {
        public PedidoMap()
        {
            ToTable("Pedido");
            Map(x => x.Id).ToColumn("IdPedido").IsKey().IsIdentity();

            Map(x => x.IdCliente).ToColumn("IdCliente");
            Map(x => x.CodigoPedido).ToColumn("CodigoPedido");
            Map(x => x.MontoSubTotal).ToColumn("MontoSubTotal");
            Map(x => x.MontoIgv).ToColumn("MontoIgv");
            Map(x => x.MontoTotal).ToColumn("MontoTotal");
            Map(x => x.Descripcion).ToColumn("Descripcion");
            Map(x => x.EstadoPedido).ToColumn("EstadoPedido");
            Map(x => x.IndActivo).ToColumn("IndActivo");
            Map(x => x.IdUsuarioRegistro).ToColumn("IdUsuarioRegistro");
            Map(x => x.FechaRegistro).ToColumn("FechaRegistro");
            Map(x => x.IdUsuarioModificacion).ToColumn("IdUsuarioModificacion");
            Map(x => x.FechaModificacion).ToColumn("FechaModificacion");


        }
    }
}
