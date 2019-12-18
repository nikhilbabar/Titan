using AutoMapper;
using System;
using System.Collections.Generic;
using Titan.Domain.Relational;
using Titan.Model;

namespace Titan.Mapper
{
    public class UserTypeMapper : Profile
    {
        public UserTypeMapper()
        {
            CreateMap<UserType, UserTypeModel>();
        }
    }
}
