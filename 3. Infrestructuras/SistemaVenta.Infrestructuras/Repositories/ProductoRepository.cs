using Dapper;
using SistemaVenta.Core.Entities;
using SistemaVenta.Core.QueryFilters;
using SistemaVenta.Infraestructura.Interfaces;
using SistemaVenta.Infrestructuras.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaVenta.Infraestructura.Repositories
{
    public class ProductoRepository : BaseRepository<Producto>, IProductoRepository
    {
        private readonly IDapperRespository _dapper;

        public ProductoRepository(IDapperRespository dapper) : base(dapper)
        {
            _dapper = dapper;
        }

        public async Task<IEnumerable<Producto>> GetProductoByUsuario(int userID)
        {
            var parms = new { id = userID };
            var sql = "sp_GetProductoByUsuario";  
            return await _dapper.sqlConection.QueryAsync<Producto>(sql, parms,null,null,CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<Producto>> GetProductosByFilters(ProductoQueryFilter Filters)
        { 
            var parms = new DynamicParameters();
            if (Filters.idUsuario != null) { parms.Add("@IdUsuarioRegistro", (int)Filters.idUsuario); }
            if (Filters.fecha != null) { parms.Add("@FechaRegistro", ((DateTime)Filters.fecha).Date); }
            if (Filters.descripcion != null) { parms.Add("@Descripcion", Filters.descripcion.ToLower()); }

            var sql = "sp_GetProductosByFilters";
            var result = await _dapper.sqlConection.QueryAsync<Producto>(sql, parms, null, null, CommandType.StoredProcedure);

            return result.ToList();
        }
    }
}
