using ATMSystem.Business.Models;
using System.Collections.Generic;

namespace ATMSystem.Business.Services
{
    public interface IUserService
    {
        IEnumerable<UserModel> GetAll();
        UserModel GetById(int id);
    }
}