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
        public AccountService(IUnitOfWork db)//, IMapper mapper)
        {
            _db = db;
            var config = new MapperConfiguration(opt => opt.CreateMap<Account, AccountModel>().ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.AccountStatus.Name)));
            _mapper = new Mapper(config);
        }
        public IEnumerable<AccountModel> GetAll()
        {
            var unmappedModels = _db.Accounts.GetAll();
            var mappedModels = _mapper.Map<IEnumerable<AccountModel>>(unmappedModels);
            return mappedModels;
        }
        public AccountModel GetById(int id)
        {
            var unmappedModel = _db.Accounts.GetById(id);
            var mappedModel = _mapper.Map<AccountModel>(unmappedModel);
            return mappedModel;
        }
    }
}
