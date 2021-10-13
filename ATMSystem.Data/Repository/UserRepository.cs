using ATMSystem.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using ATMSystem.Data.Context;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace ATMSystem.Data.Repository
{
    public class UserRepository : IRepository<User>
    {
        private readonly ATMSystemContext _db;
        public UserRepository(ATMSystemContext db)
        {
            _db = db;
        }
        public IEnumerable<User> GetAll() => _db.Users.ToList();
        public User GetById(int id) => _db.Users.Where(u => u.Id == id).FirstOrDefault();
        public void Add(User user)
        {
            _db.Users.Add(user);
        }
        public void Delete(User user)
        {
            _db.Users.Remove(user);
        }
        public void Delete(int id)
        {
            var toRemove = _db.Users.Find(id);
            if (toRemove != null)
            {
                _db.Users.Remove(toRemove);
            }
        }
        public void Update(User user)
        {
            _db.Users.Update(user);
        }
        public IEnumerable<User> FindAll(Expression<Func<User, bool>> expression)
        {
            return _db.Users.Where(expression);
        }
        public User Find(Expression<Func<User,bool>> expression)
        {
            return _db.Users.FirstOrDefault(expression);
        }
    }
}
