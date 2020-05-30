using Automapper.WebApi.DTOs;
using Automapper.WebApi.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Automapper.WebApi.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Developer, DeveloperDTO>(); //Map from Developer Object to DeveloperDTO Object
        }
    }
}
