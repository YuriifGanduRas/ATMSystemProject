using ATMSystem.Business.Models;
using System.Collections.Generic;

namespace ATMSystem.Business.Services
{
    public interface ICardService
    {
        IEnumerable<CardModel> GetAll();
        CardModel GetById(int id);
    }
}