using ATMSystem.Data.Context;
using ATMSystem.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;

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
    }
}
