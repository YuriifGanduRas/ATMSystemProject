using ATMSystem.Data.Context;
using ATMSystem.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ATMSystem.Data.Repository
{
    class CardRepository : IRepository<Card>
    {
        private readonly ATMSystemContext _db;
        public CardRepository(ATMSystemContext db)
        {
            _db = db;
        }
        public IEnumerable<Card> GetAll() => _db.Cards.ToList();
        public Card GetById(int id) => _db.Cards.Where(c => c.Id == id).FirstOrDefault();
    }
}
