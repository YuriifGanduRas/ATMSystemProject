using System;
using ATMSystem.Data.Entities;
using ATMSystem.Data.Repository;

namespace ATMSystem.Business
{
    public class UserBLL
    {
        private IRepository<User> UserRepository;
        public UserBLL(IRepository<User> repository)
        {
            UserRepository = repository;
        }
    }
}
