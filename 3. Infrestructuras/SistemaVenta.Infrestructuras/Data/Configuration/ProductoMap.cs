using Dapper.FluentMap.Dommel.Mapping;
using SistemaVenta.Core.Entities;

namespace SistemaVenta.Infrestructuras.Data.Configuration
{
    public class ProductoMap:DommelEntityMap<Producto>
    {        
        public ProductoMap()
        {
            ToTable("Producto");
            Map(x => x.Id).ToColumn("IdProducto").IsKey().IsIdentity();

            Map(x => x.CodigoProducto).ToColumn("CodigoProducto");
            Map(x => x.NombreProducto).ToColumn("NombreProducto");
            Map(x => x.Descripcion).ToColumn("Descripcion");
            Map(x => x.Imagen).ToColumn("Imagen");
            Map(x => x.IndActivo).ToColumn("IndActivo");
            Map(x => x.IdUsuarioRegistro).ToColumn("IdUsuarioRegistro");
            Map(x => x.FechaRegistro).ToColumn("FechaRegistro");
            Map(x => x.IdUsuarioModificacion).ToColumn("IdUsuarioModificacion");
            Map(x => x.FechaModificacion).ToColumn("FechaModificacion");

        }
    }
}
