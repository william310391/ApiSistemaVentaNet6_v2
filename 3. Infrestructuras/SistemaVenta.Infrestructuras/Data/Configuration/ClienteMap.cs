using Dapper.FluentMap.Dommel.Mapping;
using SistemaVenta.Core.Entities;

namespace SistemaVenta.Infrestructuras.Data.Configuration
{
    public class ClienteMap : DommelEntityMap<Cliente>
    {
        public ClienteMap()
        {
            ToTable("Cliente");
            Map(x => x.Id).ToColumn("IdCliente").IsKey().IsIdentity();

            Map(x => x.Nombre).ToColumn("Nombre");
            Map(x => x.ApellidoPaterno).ToColumn("ApellidoPaterno");
            Map(x => x.ApallidoMaterno).ToColumn("ApallidoMaterno");
            Map(x => x.RazonSocial).ToColumn("RazonSocial");
            Map(x => x.IdTipoDocumento).ToColumn("IdTipoDocumento");
            Map(x => x.NumeroDocumento).ToColumn("NumeroDocumento");
            Map(x => x.FechaNacimiento).ToColumn("FechaNacimiento");
            Map(x => x.IndActivo).ToColumn("IndActivo");
            Map(x => x.IdUsuarioRegistro).ToColumn("IdUsuarioRegistro");
            Map(x => x.FechaRegistro).ToColumn("FechaRegistro");
            Map(x => x.IdUsuarioModificacion).ToColumn("IdUsuarioModificacion");
            Map(x => x.FechaModificacion).ToColumn("FechaModificacion");

        }
    }
}
