using Microsoft.EntityFrameworkCore;
using SistemaVenta.Core.DTOs;
using SistemaVenta.Core.Entities;
using SistemaVenta.Infraestructura.Data;
using SistemaVenta.Infraestructura.Interfaces;
using SistemaVenta.Infraestructura.Repositories;
using SistemaVenta.Infrestructuras.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVenta.Infrestructuras.Repositories
{
    public class UsuarioRepository : BaseRepository<Usuario>, IUsuarioRepository
    {
        private readonly IDapperRespository _dapper;
        public UsuarioRepository(VentasContext context, IDapperRespository dapper) : base(context, dapper)
        {
            _dapper = dapper;
        }           

        public async Task<Usuario> GetLoginByCredentials(UsuarioDTO usuarioDTO)
        {
            return await _entities.AsQueryable()
                .Where(x => x.Cuenta == usuarioDTO.Cuenta.Trim())
                .FirstOrDefaultAsync();
        }
    }
}
