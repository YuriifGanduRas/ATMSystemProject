using ATMSystem.Business.Models;
using System.Collections.Generic;

namespace ATMSystem.Business.Services
{
    public interface IAccountService
    {
        IEnumerable<AccountModel> GetAll();
        AccountModel GetById(int id);
    }
}