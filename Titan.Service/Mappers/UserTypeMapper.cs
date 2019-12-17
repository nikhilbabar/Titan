using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using Titan.Domain.Relational;
using Titan.Model;

namespace Titan.Service.Mappers
{
    public class UserTypeMapper : Profile
    {
        public UserTypeMapper()
        {
            CreateMap<UserType, UserTypeModel>();
        }
    }
}
