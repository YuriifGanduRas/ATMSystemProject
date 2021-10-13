using ATMSystem.Business.Models;
using ATMSystem.Data.Context;
using ATMSystem.Data.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace ATMSystem.Business.Services
{
    public class CardService : ICardService
    {
        private readonly IUnitOfWork _db;
        private readonly IMapper _mapper;
        public CardService(IUnitOfWork db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }
        public CardModel GetCardInfo(long cardNumber, int password)
        {
            Card cardStatus = _db.CardRepository.Find(rcard => rcard.Number == cardNumber && rcard.Password == password);
            if (cardStatus == null)
            {
                return null; //Implement custom exception!!!
            }
            CardModel mappedCardStatus = _mapper.Map<Card, CardModel>(cardStatus);
            return mappedCardStatus;
        }
        public void GetMoneyFromCard(long cardNumber, int password, decimal sum)
        {
            Card userCard = _db.CardRepository.Find(rcard => rcard.Number == cardNumber && rcard.Password == password);
            if (userCard == null)
            {
                throw new Exception(); //Implement custom exception!!!
            }
            var cardStatus = userCard.Account.AccountStatus.Name;
            if (cardStatus == "Frozen" || cardStatus == "Closed")
            {
                throw new Exception(); //Implement custom exception!!!
            }
            var cardBalance = userCard.Account.Balance;
            if (cardBalance < sum)
            {
                throw new Exception(); //Implement custom exception!!!
            }
            cardBalance -= sum;
        }
        public void GetMoneyOnCard(long cardNumber, int password, decimal sum)
        {
            Card userCard = _db.CardRepository.Find(rcard => rcard.Number == cardNumber && rcard.Password == password);
            if (userCard == null)
            {
                throw new Exception(); //Implement custom exception!!!
            }
            var cardStatus = userCard.Account.AccountStatus.Name;
            if (cardStatus == "Frozen" || cardStatus == "Closed")
            {
                throw new Exception(); //Implement custom exception!!!
            }
            var cardBalance = userCard.Account.Balance;
            cardBalance += sum;
        }
    }
}
