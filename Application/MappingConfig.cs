using AutoMapper;
using Domain.DTO;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class MappingConfig : Profile
    {
        public MappingConfig() 
        {
            CreateMap<Product, ProductDto>()
                .ForMember(dest => dest.AttributesList, opt => opt.MapFrom(src => src.Characteristics_Value))
                .ReverseMap();
            CreateMap<Characteristic_Value, CharacteristicDto>()
                .ForMember(dest => dest.Characteristic_Name, opt => opt.MapFrom(src => src.Characteristic.Characteristic_Name))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.Value))
                .ReverseMap();
        }
    }
}
