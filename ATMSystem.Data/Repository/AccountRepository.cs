using ATMSystem.Data.Context;
using ATMSystem.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ATMSystem.Data.Repository
{
    class AccountRepository : IRepository<Account>
    {
        private ATMSystemContext _db;
        public AccountRepository(ATMSystemContext db)
        {
            _db = db;
        }
        public IEnumerable<Account> All => _db.Accounts.ToList();
    }
}
