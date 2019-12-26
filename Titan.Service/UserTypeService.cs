using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Titan.Domain.Relational;
using Titan.Model;
using Titan.Repository.Interface;
using Titan.Service.Interface;

namespace Titan.Service
{
    public class UserTypeService : BaseService<UserType>, IUserTypeService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UserTypeService(IUnitOfWork unitOfWork, IMapper mapper)
            : base(unitOfWork.GetRepository<UserType>())
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            
        }

        public async Task<List<UserTypeModel>> GetAsync()
        {
            var entities = await GetEntitiesAsync();
            var types = _mapper.Map<List<UserTypeModel>>(entities.ToList());
            return types;
        }

        public async Task<UserTypeModel> GetAsync(byte id)
        {
            var entity = await GetEntitiesAsync(x=> x.Id == id);
            var type = _mapper.Map<UserTypeModel>(entity.First());
            return type;
        }
    }
}
