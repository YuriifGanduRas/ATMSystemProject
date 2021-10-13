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
    class CardRepository : IRepository<Card>
    {
        private readonly ATMSystemContext _db;
        public CardRepository(ATMSystemContext db)
        {
            _db = db;
        }
        public IEnumerable<Card> GetAll() => _db.Cards.Include(card => card.User).Include(card => card.Bank).Include(card => card.CardType).ToList();
        public Card GetById(int id) => _db.Cards.Where(c => c.Id == id).Include(card => card.User).Include(card => card.Bank).Include(card => card.CardType).FirstOrDefault();
        public void Add(Card card)
        {
            _db.Cards.Add(card);
        }
        public void Delete(Card card)
        {
            _db.Cards.Remove(card);
        }
        public void Delete(int id)
        {
            var toRemove = _db.Cards.Find(id);
            if (toRemove != null)
            {
                _db.Cards.Remove(toRemove);
            }
        }
        public void Update(Card card)
        {
            _db.Cards.Update(card);
        }
        public IEnumerable<Card> FindAll(Expression<Func<Card, bool>> expression)
        {
            return _db.Cards.Where(expression).Include(card => card.User).Include(card => card.Bank).Include(card => card.Account).Include(card => card.CardType);
        }
        public Card Find(Expression<Func<Card,bool>> expression)
        {
            return _db.Cards.Include(card => card.User).Include(card => card.Bank).Include(card => card.Account).Include(card => card.CardType).FirstOrDefault(expression);
        }
    }
}
