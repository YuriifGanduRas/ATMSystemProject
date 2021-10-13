using ATMSystem.Business.Models;
using ATMSystem.Data.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace ATMSystem.Business.Profiles
{
    public class AccountProfile : Profile
    {
        public AccountProfile()
        {
            CreateMap<Account, AccountModel>()
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.AccountStatus.Name));
        }
    }
}
