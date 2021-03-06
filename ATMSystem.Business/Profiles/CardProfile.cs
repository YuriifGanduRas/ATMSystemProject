using ATMSystem.Business.Models;
using ATMSystem.Data.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ATMSystem.Business.Profiles
{
    class CardProfile : Profile
    {
        public CardProfile()
        {
            CreateMap<Card, CardModel>().ForMember(dest => dest.OwnerFirstName, opt => opt.MapFrom(src => src.User.FirstName))
                .ForMember(dest => dest.OwnerLastName, opt => opt.MapFrom(src => src.User.LastName))
                .ForMember(dest => dest.Type, opt => opt.MapFrom(src => src.CardType.Name))
                .ForMember(dest => dest.Bank, opt => opt.MapFrom(src => src.Bank.Name));
        }
    }
}
