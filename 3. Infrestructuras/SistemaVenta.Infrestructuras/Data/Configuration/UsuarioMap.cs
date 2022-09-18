using Dapper.FluentMap.Dommel.Mapping;
using SistemaVenta.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVenta.Infrestructuras.Data.Configuration
{
    public class UsuarioMap: DommelEntityMap<Usuario>
    {
        public UsuarioMap()
        {
            ToTable("Usuario");
            Map(x => x.Id).ToColumn("IdUsuario").IsKey().IsIdentity();

            Map(x => x.Cuenta).ToColumn("Cuenta");
            Map(x => x.Contrasena).ToColumn("Contrasena");
            Map(x => x.NombreUsuario).ToColumn("NombreUsuario");
            Map(x => x.IdRol).ToColumn("IdRol");
            Map(x => x.IndActivo).ToColumn("IndActivo");
            Map(x => x.IdUsuarioRegistro).ToColumn("IdUsuarioRegistro");
            Map(x => x.FechaRegistro).ToColumn("FechaRegistro");
            Map(x => x.IdUsuarioModificacion).ToColumn("IdUsuarioModificacion");
            Map(x => x.FechaModificacion).ToColumn("FechaModificacion");
        }
    }
}
