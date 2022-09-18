using Dapper;
using SistemaVenta.Core.DTOs;
using SistemaVenta.Core.Entities;
using SistemaVenta.Infraestructura.Interfaces;
using SistemaVenta.Infraestructura.Repositories;
using SistemaVenta.Infrestructuras.Interfaces;
using System.Data;
using System.Threading.Tasks;

namespace SistemaVenta.Infrestructuras.Repositories
{
    public class UsuarioRepository : BaseRepository<Usuario>, IUsuarioRepository
    {
        private readonly IDapperRespository _dapper;
        public UsuarioRepository(IDapperRespository dapper) : base(dapper)
        {
            _dapper = dapper;
        }           

        public async Task<Usuario> GetLoginByCredentials(UsuarioDTO usuarioDTO)
        {

            var parms = new
            {
                @Usuario = usuarioDTO.Cuenta.Trim(),
            };
            var sql = "sp_GetLoginByCredentialsUsuario";
            return (Usuario)await _dapper.sqlConection.QueryAsync<Usuario>(sql, parms, null, null, CommandType.StoredProcedure);
        
        }
    }
}
