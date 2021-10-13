using ATMSystem.Data.Entities;
using ATMSystem.Data.Repository;

namespace ATMSystem.Data.Context
{
    public interface IUnitOfWork
    {
        public IRepository<Account> AccountRepository { get; }
        public IRepository<Card> CardRepository { get; }
        public IRepository<User> UserRepository { get; }
        public void Save() { }
    }
}