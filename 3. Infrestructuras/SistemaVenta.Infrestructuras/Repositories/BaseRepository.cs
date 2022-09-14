using Microsoft.EntityFrameworkCore;
using SistemaVenta.Infraestructura.Data;
using SistemaVenta.Core.Entities;
using SistemaVenta.Infraestructura.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaVenta.Core.Exceptions;
using Dapper.Contrib;
using SistemaVenta.Infrestructuras.Interfaces;
using Dapper.Contrib.Extensions;

namespace SistemaVenta.Infraestructura.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {

        private readonly VentasContext _context;
        protected readonly DbSet<T> _entities;
        private readonly IDapperRespository _dapper;
        public BaseRepository(VentasContext context, IDapperRespository dapper)
        {
            _context = context;
            _entities = context.Set<T>();
            _dapper = dapper;
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _dapper.sqlConection.GetAllAsync<T>();//  _entities.AsEnumerable();
        }



        public async Task<T> GetById(int Id)
        {

            var ent = await _dapper.sqlConection.GetAsync<T>(Id);  //await _entities.Where(x => x.Id == Id).FirstOrDefaultAsync();
            if (ent != null)
            {
                return ent;
            }
            else
            {
                throw new BusinessException("El Id del registro no existe");
            }


            //var ent = await _entities.Where(x => x.Id == Id).FirstOrDefaultAsync();
            //if (ent != null){
            //    return ent;
            //}
            //else {
            //    throw new BusinessException("El Id del registro no existe");
            //}

        }

        public async Task Add(T entity)
        {
            await _dapper.sqlConection.InsertAsync<T>(entity);
           //await _entities.AddAsync(entity);            
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
