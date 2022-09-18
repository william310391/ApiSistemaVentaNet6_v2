//using Dapper.Contrib.Extensions;
using Dommel;
using SistemaVenta.Core.Entities;
using SistemaVenta.Core.Exceptions;
using SistemaVenta.Infraestructura.Interfaces;
using SistemaVenta.Infrestructuras.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SistemaVenta.Infraestructura.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        private readonly IDapperRespository _dapper;
        public BaseRepository(IDapperRespository dapper)
        {
            _dapper = dapper;
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _dapper.sqlConection.GetAllAsync<T>();
        }

        public async Task<T> GetById(int Id)
        {            
            var ent = await _dapper.sqlConection.GetAsync<T>(Id);  
            if (ent != null)
            {
                return ent;
            }
            else
            {
                throw new BusinessException("El Id del registro no existe");
            }
        }

        public async Task Add(T entity)
        {
            await _dapper.sqlConection.InsertAsync<T>(entity);        
        }

        public async void Update(T entity)
        {

            var ent = await GetById(entity.Id);

            if (ent != null)
            {
                await _dapper.sqlConection.UpdateAsync<T>(entity);                
            }
            else
            {
                throw new BusinessException("El Id del registro no existe");
            }    
        } 

        public async Task Delete(int Id)
        {
            T entity = await GetById(Id);
            if (entity != null)
            {              
                _dapper.sqlConection.Delete<T>(entity);
            }
            else {
                throw new RespuestaException("El registro ya se encuentra eliminado");
            }
                    
        }    

    }


}
