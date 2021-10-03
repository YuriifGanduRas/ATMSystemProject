using ATMSystem.Business.Models;
using System.Collections.Generic;

namespace ATMSystem.Business.Services
{
    public interface IBankService
    {
        IEnumerable<BankModel> GetAll();
        BankModel GetById(int id);
    }
}