using ATMSystem.Business.Models;
using ATMSystem.Data.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace ATMSystem.Business.Profiles
{
    class BankProfile : Profile
    {
        public BankProfile()
        {
            CreateMap<Bank, BankModel>();
        }
    }
}
