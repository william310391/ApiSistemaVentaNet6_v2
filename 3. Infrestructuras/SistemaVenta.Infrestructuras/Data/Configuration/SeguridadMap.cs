using Dapper.FluentMap.Dommel.Mapping;
using SistemaVenta.Core.Entities;

namespace SistemaVenta.Infrestructuras.Data.Configuration
{
    public class SeguridadMap :DommelEntityMap<Seguridad>
    {
        public SeguridadMap()
        {
            ToTable("Pedido");
            Map(x => x.Id).ToColumn("IdSeguridad").IsKey().IsIdentity();

            Map(x => x.Usuario).ToColumn("Usuario");
            Map(x => x.NombreUsuario).ToColumn("NombreUsuario");
            Map(x => x.Contrasena).ToColumn("Contrasena");
            Map(x => x.Rol).ToColumn("Rol");
            Map(x => x.IndActivo).ToColumn("IndActivo");
            Map(x => x.IdUsuarioRegistro).ToColumn("IdUsuarioRegistro");
            Map(x => x.FechaRegistro).ToColumn("FechaRegistro");
            Map(x => x.IdUsuarioModificacion).ToColumn("IdUsuarioModificacion");
            Map(x => x.FechaModificacion).ToColumn("FechaModificacion");
        }
    }
}
