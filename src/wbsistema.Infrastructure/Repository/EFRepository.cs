using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using wbsistema.ApplicationCore.Interfaces.Repository;
using wbsistema.Infrastructure.Data;

namespace wbsistema.Infrastructure.Repository
{
    public class EFRepository<T> : IRepository<T> where T : class
    {
        protected readonly ClienteContext _dbContext;

        public EFRepository(ClienteContext dbContext)
        {
            _dbContext = dbContext;
        }


        public T Add(T entity)
        {
            _dbContext.Set<T>().Add(entity);
            _dbContext.SaveChanges();
            return entity;
        }

        public void Delete(T entity)
        {
            _dbContext.Set<T>().Remove(entity);
            _dbContext.SaveChanges();
        }

        public IEnumerable<T> Get()
        {
            return _dbContext.Set<T>().AsEnumerable();
        }

        public T Get(int id)
        {
            return _dbContext.Set<T>().Find(id);
        }

        public IEnumerable<T> Get(Expression<Func<T, bool>> predicado)
        {
            return _dbContext.Set<T>().Where(predicado).AsEnumerable();
        }

        public void Update(T entity)
        {
            _dbContext.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _dbContext.SaveChanges();
        }
    }
}
