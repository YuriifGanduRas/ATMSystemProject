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
        public BankService(IUnitOfWork db)//, IMapper mapper)
        {
            _db = db;
            var config = new MapperConfiguration(opt => opt.CreateMap<Bank, BankModel>());
            _mapper = new Mapper(config);
        }
        public IEnumerable<BankModel> GetAll()
        {
            var unmappedModels = _db.Banks.GetAll();
            var mappedModels = _mapper.Map<IEnumerable<BankModel>>(unmappedModels);
            return (IEnumerable<BankModel>)mappedModels;
        }
        public BankModel GetById(int id)
        {
            var unmappedModel = _db.Banks.GetById(id);
            var mappedModel = _mapper.Map<BankModel>(unmappedModel);
            return mappedModel;
        }
    }
}
