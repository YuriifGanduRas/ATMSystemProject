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
        public IEnumerable<CardModel> GetAll()
        {
            var unmappedModels = _db.Cards.GetAll();
            var mappedModels = _mapper.Map<IEnumerable<CardModel>>(unmappedModels);
            return mappedModels;
        }
        public CardModel GetById(int id)
        {
            var unmappedModel = _db.Cards.GetById(id);
            var mappedModel = _mapper.Map<CardModel>(unmappedModel);
            return mappedModel;
        }
    }
}
