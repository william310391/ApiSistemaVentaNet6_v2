using SistemaVenta.Core.Entities;
using SistemaVenta.Infraestructura.Interfaces;
using SistemaVenta.Negocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVenta.Negocio.Services
{   
    public class ClienteDapperService: IClienteDapperService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ClienteDapperService(IUnitOfWork unitOfWork)
        {
            _unitOfWork=unitOfWork;
        }

        public List<Cliente> GetListCliente()
        {
           return _unitOfWork.ClienteDapperRepository.GetListCliente();
        }

        public async Task<List<Cliente>> GetListCliente2()
        {
            return await _unitOfWork.ClienteDapperRepository.GetListCliente2();
        }
    }
}
