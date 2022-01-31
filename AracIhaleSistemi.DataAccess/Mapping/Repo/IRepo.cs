using AracIhaleSistemi.DataAccess.Mapping.Core;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AracIhaleSistemi.DataAccess.Mapping.Repo
{
    public interface IRepo<T> where T : class, IEntity, new()
    {
        T Get(Expression<Func<T, bool>> filter = null);

        List<T> GetAll(Expression<Func<T, bool>> filter = null);

        T Add(T entity);
        T Update(T entity);

        int Delete(T entity);
        Task<IEnumerable<T>> GetAllAsync();

    }
}
