using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TakeHome.Models;
using TakeHome.Models.InvoiceViewModels;
using TakeHome.WebAPI.Data.Entities;

namespace TakeHome.WebAPI.Mappings
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Invoice, InvoiceViewModel>().ReverseMap();
            //CreateMap<UserDetail, UserViewModel>().ReverseMap();
            //CreateMap<Talk, TalkModel>()
            //    .ReverseMap()
            //    .ForMember(t => t.Camp, opt => opt.Ignore())
            //    .ForMember(t => t.Speaker, opt => opt.Ignore());
            //CreateMap<Speaker, SpeakerModel>()
            //    .ReverseMap();
        }
    }
}
