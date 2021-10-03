using ATMSystem.Data.Entities;
using ATMSystem.Data.Repository;

namespace ATMSystem.Data.Context
{
    public class UnitOfWork : IUnitOfWork
    {
        private ATMSystemContext _dbContext;
        private IRepository<User> _userRepository;
        private IRepository<Account> _accountRepository;
        private IRepository<Card> _cardRepository;
        private IRepository<Bank> _bankRepository;
        public UnitOfWork(ATMSystemContext dbcContext)
        {
            _dbContext = dbcContext;
        }

        public IRepository<User> Users { get { if (_userRepository == null) { _userRepository = new UserRepository(_dbContext); }; return _userRepository; } }
        public IRepository<Account> Accounts { get { if (_accountRepository == null) { _accountRepository = new AccountRepository(_dbContext); }; return _accountRepository; } }
        public IRepository<Card> Cards { get { if (_cardRepository == null) { _cardRepository = new CardRepository(_dbContext); }; return _cardRepository; } }
        public IRepository<Bank> Banks { get { if (_bankRepository == null) { _bankRepository = new BankRepository(_dbContext); }; return _bankRepository; } }
        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}
