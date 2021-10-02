using ATMSystem.Data.Context;
using ATMSystem.Data.Entities;
using ATMSystem.Data.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace ATMSystem.Data.Interfaces
{
    class IUnitOfWork
    {
        private readonly ATMSystemContext _dbContext;
        private readonly IRepository<User> _userRepository;
        private readonly IRepository<Account> _accountRepository;
        private readonly IRepository<Card> _cardRepository;
        private readonly IRepository<Bank> _bankRepository;
        public IUnitOfWork() { }

        public IRepository<User> Users { get; }
        public IRepository<Account> Accounts { get; }
        public IRepository<Card> Cards { get; }
        public IRepository<Bank> Banks { get; }

    }
}
