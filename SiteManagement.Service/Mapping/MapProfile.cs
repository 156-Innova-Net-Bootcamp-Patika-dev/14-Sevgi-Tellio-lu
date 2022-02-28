using AutoMapper;
using SiteManagament.Core;
using SiteManagament.Core.DTO;
using SiteManagament.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteManagement.Service.Mapping
{
   public class MapProfile:Profile
    {
        public MapProfile()
        {
            CreateMap<Tenant, TenantDto>().ReverseMap();
            CreateMap<Apartment, ApartmentDto>().ReverseMap();
            CreateMap<Payment, PaymentDto>().ReverseMap();
            CreateMap<Message, MessageDto>().ReverseMap();
            CreateMap<CreditCard, CreditCardDto>().ReverseMap();
        }
        
    }
}
