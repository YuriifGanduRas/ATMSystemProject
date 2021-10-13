using ATMSystem.Data.Context;
using ATMSystem.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace ATMSystem.Data.Repository
{
    class CardRepository : IRepository<Card>
    {
        private readonly ATMSystemContext _db;
        public CardRepository(ATMSystemContext db)
        {
            _db = db;
        }
        public IEnumerable<Card> GetAll() => _db.Cards.Include(card => card.User).Include(card => card.Bank).Include(card => card.CardType).ToList();
        public Card GetById(int id) => _db.Cards.Where(c => c.Id == id).Include(card => card.User).Include(card => card.Bank).Include(card => card.CardType).FirstOrDefault();
    }
}
