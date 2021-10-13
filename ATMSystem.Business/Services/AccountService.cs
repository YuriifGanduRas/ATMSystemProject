using ATMSystem.Business.Models;
using ATMSystem.Data.Context;
using ATMSystem.Data.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace ATMSystem.Business.Services
{
    public class AccountService : IAccountService
    {
        private readonly IUnitOfWork _db;
        private readonly IMapper _mapper;
        public AccountService(IUnitOfWork db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }
        public IEnumerable<AccountModel> GetAll()
        {
            var unmappedModels = _db.AccountRepository.GetAll();
            var mappedModels = _mapper.Map<IEnumerable<AccountModel>>(unmappedModels);
            return mappedModels;
        }
        public AccountModel GetById(int id)
        {
            var unmappedModel = _db.AccountRepository.GetById(id);
            var mappedModel = _mapper.Map<AccountModel>(unmappedModel);
            return mappedModel;
        }
    }
}
