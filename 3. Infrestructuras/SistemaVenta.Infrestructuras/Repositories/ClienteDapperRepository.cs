using Dapper;
using SistemaVenta.Core.Entities;
using SistemaVenta.Infrestructuras.Interfaces;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaVenta.Infrestructuras.Repositories
{
    public class ClienteDapperRepository: IClienteDapperRepository
    { 
        private readonly IDapperRespository _dapper;
        public ClienteDapperRepository(IDapperRespository dapper)
        {
            _dapper = dapper;
        }

        public List<Cliente> GetListCliente()
        {            
            List<Cliente> lista = new List<Cliente>();       
            var sql = "sp_listar_cliente";
            lista = _dapper.sqlConection.Query<Cliente>(sql, null, null, true, null, CommandType.StoredProcedure).ToList();
            return lista;
        }

        public async Task<List<Cliente>> GetListCliente2()
        {   
            List<Cliente> lista = new List<Cliente>();
            var sql = "sp_listar_cliente";
            lista = (List<Cliente>)await _dapper.sqlConection.QueryAsync<Cliente>(sql, null, null, null, CommandType.StoredProcedure);
            return lista;
        }


        public async Task<List<Product>> GetlistProduct()
        {
            List<Product> lista = new List<Product>();
            var sql = "select *from product";
            lista = (List<Product>)await _dapper.mySqlConection.QueryAsync<Product>(sql, null, null, null, CommandType.Text);
            return lista;
        }
        //https://riptutorial.com/dapper-contrib/learn/100004/insert-data
        //Dapper.Contrib
    }
}
