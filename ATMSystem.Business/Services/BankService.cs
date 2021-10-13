using ATMSystem.Business.Models;
using ATMSystem.Data.Context;
using ATMSystem.Data.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace ATMSystem.Business.Services
{
    public class BankService : IBankService
    {
        private readonly IUnitOfWork _db;
        private readonly IMapper _mapper;
        public BankService(IUnitOfWork db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }
        public IEnumerable<BankModel> GetAll()
        {
            var unmappedModels = _db.BankRepository.GetAll();
            var mappedModels = _mapper.Map<IEnumerable<BankModel>>(unmappedModels);
            return mappedModels;
        }
        public BankModel GetById(int id)
        {
            var unmappedModel = _db.BankRepository.GetById(id);
            var mappedModel = _mapper.Map<BankModel>(unmappedModel);
            return mappedModel;
        }
    }
}
