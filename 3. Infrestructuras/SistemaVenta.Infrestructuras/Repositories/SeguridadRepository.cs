using Microsoft.EntityFrameworkCore;
using SistemaVenta.Core.DTOs;
using SistemaVenta.Core.Entities;
using SistemaVenta.Infraestructura.Data;
using SistemaVenta.Infraestructura.Repositories;
using SistemaVenta.Infrestructuras.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVenta.Infrestructuras.Repositories
{
    public class SeguridadRepository : BaseRepository<Seguridad>, ISeguridadRepository
    {
        private readonly IDapperRespository _dapper;
        public SeguridadRepository(VentasContext context, IDapperRespository dapper) : base(context, dapper)
        {
            _dapper = dapper;
        }

        public async Task<Seguridad> GetLoginByCredentials(SeguridadDTO seguridadDTO)
        {
            return await _entities.AsQueryable()
                .Where(x => x.Usuario == seguridadDTO.Usuario.Trim())
               // .Where(x => x.Contrasena == seguridadDTO.Contrasena)
                .FirstOrDefaultAsync();
        }
    }
}
