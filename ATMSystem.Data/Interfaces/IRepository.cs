using ATMSystem.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace ATMSystem.Data.Repository
{
    public interface IRepository<TEntity> where TEntity : class
    {
        public IEnumerable<TEntity> GetAll();
        public TEntity GetById(int id);
    }
}
