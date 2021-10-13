using ATMSystem.Data.Context;
using ATMSystem.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace ATMSystem.Data.Repository
{
    class BankRepository : IRepository<Bank>
    {
        private readonly ATMSystemContext _db;
        public BankRepository(ATMSystemContext db)
        {
            _db = db;
        }
        public IEnumerable<Bank> GetAll() => _db.Banks.ToList();
        public Bank GetById(int id) => _db.Banks.Where(b => b.Id == id).FirstOrDefault();
    }
}
