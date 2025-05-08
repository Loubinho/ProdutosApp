using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdutosApp.Domain.Interfaces.Repositories
{
    public interface IBaseRepository<TEntity, TKey>
        where TEntity : class
    {
        Task AddAsync(TEntity entity);
        Task UpdateAsync(TEntity entity);
        Task DeleteAsync(TKey id);

        Task<TEntity> GetByIdAsync(TKey id);        
        Task<List<TEntity>> GetAllAsync(); //Usado quando o resultado da consulta não pode ser alterada
        //Task<IEnumerable<TEntity>> GetAllAsync(); //Usado quando o resultado da consulta pode ser alterada
    }
}
