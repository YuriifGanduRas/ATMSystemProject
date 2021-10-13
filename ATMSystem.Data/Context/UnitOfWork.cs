using ATMSystem.Data.Entities;
using ATMSystem.Data.Repository;

namespace ATMSystem.Data.Context
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ATMSystemContext _dbContext;
        public UnitOfWork(ATMSystemContext dbcContext)
        {
            _dbContext = dbcContext;
        }

        public IRepository<User> UserRepository => new UserRepository(_dbContext);
        public IRepository<Account> AccountRepository => new AccountRepository(_dbContext);
        public IRepository<Card> CardRepository => new CardRepository(_dbContext);
        public IRepository<Bank> BankRepository => new BankRepository(_dbContext);
        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}
