using ATMSystem.Data.Context;
using ATMSystem.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace ATMSystem.Data.Repository
{
    class AccountRepository : IRepository<Account>
    {
        private readonly ATMSystemContext _db;
        public AccountRepository(ATMSystemContext db)
        {
            _db = db;
        }
        public IEnumerable<Account> GetAll() => _db.Accounts.Include(account => account.AccountStatus).ToList();
        public Account GetById(int id) => _db.Accounts.Where(a => a.Id == id).Include(account => account.AccountStatus).FirstOrDefault();
        public void Add(Account account)
        {
            _db.Accounts.Add(account);
        }
        public void Delete(Account account)
        {
            _db.Accounts.Remove(account);
        }
        public void Delete(int id)
        {
            var toRemove =_db.Accounts.Find(id);
            if (toRemove != null)
            {
                _db.Accounts.Remove(toRemove);
            }
        }
        public void Update(Account account)
        {
            _db.Accounts.Update(account);
        }
        public IEnumerable<Account> FindAll(Expression<Func<Account, bool>> expression)
        {
            return _db.Accounts.Where(expression);
        }
        public Account Find(Expression<Func<Account,bool>> expression)
        {
            return _db.Accounts.FirstOrDefault(expression);
        }
    }
}
