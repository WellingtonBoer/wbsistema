using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using wbsistema.ApplicationCore.Interfaces.Repository;

namespace wbsistema.Infrastructure.Repository
{
    public class NHRepository<T> : IRepository<T> where T : class
    {
        public T Add(T entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> Get()
        {
            throw new NotImplementedException();
        }

        public T Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> Get(Expression<Func<T, bool>> predicado)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
