using ATMSystem.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using ATMSystem.Data.Context;
using System.Linq;

namespace ATMSystem.Data.Repository
{
    public class UserRepository : IRepository<User>
    {
        private ATMSystemContext _db;
        public UserRepository(ATMSystemContext db)
        {
            _db = db;
        }
        public IEnumerable<User> All => _db.Users.ToList();
    }
}
