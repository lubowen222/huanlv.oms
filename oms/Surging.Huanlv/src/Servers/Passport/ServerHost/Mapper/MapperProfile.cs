using AutoMapper;
using Huanlv.Passport.Domain.AggregatesModel.UserAggregate;
using Huanlv.Passport.IApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Huanlv.Passport.ServerHost.Mapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            RegisterMap<UserDto, UserInfo>();
        }

        void RegisterMap<T, S>()
        {
            CreateMap<T, S>();
            CreateMap<S, T>();
        }

    }
}
