using SistemaVenta.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVenta.Infrestructuras.Interfaces
{
    public interface IClienteDapperRepository
    {
        List<Cliente> GetListCliente();
        Task<List<Cliente>> GetListCliente2();
    }
}
