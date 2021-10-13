using ATMSystem.Business.Models;
using ATMSystem.Data.Context;
using ATMSystem.Data.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace ATMSystem.Business.Services
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _db;
        private readonly IMapper _mapper;
        public UserService(IUnitOfWork db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }
        public IEnumerable<UserModel> GetAll()
        {
            var unmappedModels = _db.UserRepository.GetAll();
            var mappedModels = _mapper.Map<IEnumerable<UserModel>>(unmappedModels);
            return mappedModels;
        }
        public UserModel GetById(int id)
        {
            var unmappedModel = _db.UserRepository.GetById(id);
            var mappedModel = _mapper.Map<UserModel>(unmappedModel);
            return mappedModel;
        }
    }
}
