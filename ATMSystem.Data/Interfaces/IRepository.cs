using ATMSystem.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace ATMSystem.Data.Repository
{
    public interface IRepository<TEntity> where TEntity : class
    {
        public IEnumerable<TEntity> GetAll();
        public TEntity GetById(int id);
        public void Add(TEntity entity);
        public void Delete(TEntity entity);
        public void Delete(int id);
        public void Update(TEntity entity);
        public IEnumerable<TEntity> FindAll(Expression<Func<TEntity, bool>> expression);
        public TEntity Find(Expression<Func<TEntity, bool>> expression);
    }
}
