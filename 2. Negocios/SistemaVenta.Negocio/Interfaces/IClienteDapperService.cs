using SistemaVenta.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVenta.Negocio.Interfaces
{
    public interface IClienteDapperService
    {
        List<Cliente> GetListCliente();
        Task<List<Cliente>> GetListCliente2();
    }
}
