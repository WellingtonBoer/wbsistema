using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace wbsistema.ApplicationCore.Interfaces.Repository
{
    public interface IRepository<T> where T : class
    {
        T Add(T entity);
        void Update(T entity);
        IEnumerable<T> Get();
        T Get(int id);
        IEnumerable<T> Get(Expression<Func<T, bool>> predicado);
        void Delete(T entity);
    }
}
