using Dapper;
using SistemaVenta.Core.DTOs;
using SistemaVenta.Core.Entities;
using SistemaVenta.Infraestructura.Repositories;
using SistemaVenta.Infrestructuras.Interfaces;
using System.Data;
using System.Threading.Tasks;

namespace SistemaVenta.Infrestructuras.Repositories
{
    public class SeguridadRepository : BaseRepository<Seguridad>, ISeguridadRepository
    {
        private readonly IDapperRespository _dapper;
        public SeguridadRepository(IDapperRespository dapper) : base(dapper)
        {
            _dapper = dapper;
        }

        public async Task<Seguridad> GetLoginByCredentials(SeguridadDTO seguridadDTO)
        {

            var parms = new
            {
                @Usuario = seguridadDTO.Usuario.Trim(),
            };
            var sql = "sp_GetLoginByCredentialsSeguridad";
            return (Seguridad)await _dapper.sqlConection.QueryAsync<Seguridad>(sql, parms, null, null, CommandType.StoredProcedure);
        }
    }
}
