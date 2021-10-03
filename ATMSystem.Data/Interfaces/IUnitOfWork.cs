using ATMSystem.Data.Entities;
using ATMSystem.Data.Repository;

namespace ATMSystem.Data.Context
{
    public interface IUnitOfWork
    {
        IRepository<Account> Accounts { get; }
        IRepository<Bank> Banks { get; }
        IRepository<Card> Cards { get; }
        IRepository<User> Users { get; }
        public void Save() { }
    }
}