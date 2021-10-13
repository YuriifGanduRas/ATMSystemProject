using ATMSystem.Business.Models;
using ATMSystem.Data.Entities;
using System.Collections.Generic;

namespace ATMSystem.Business.Services
{
    public interface ICardService
    {
        public CardModel GetCardInfo(long cardNumber, int password);
        public void GetMoneyFromCard(long cardNumber, int password, decimal sum);
        public void GetMoneyOnCard(long cardNumber, int password, decimal sum);
    }
}