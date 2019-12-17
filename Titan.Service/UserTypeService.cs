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
    public class UserTypeService : IUserTypeService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IGenericRepository<UserType> _repository;
        private readonly IMapper _mapper;

        public UserTypeService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _repository = _unitOfWork.GetRepository<UserType>();
        }

        public async Task<List<UserTypeModel>> GetAsync()
        {
            var entities = await _repository.GetAsync();
            var types = _mapper.Map<List<UserTypeModel>>(entities.ToList());
            return types;
        }

        public async Task<UserTypeModel> GetAsync(byte id)
        {
            var entity = await _repository.GetAsync(x=> x.Id == id);
            var type = _mapper.Map<UserTypeModel>(entity.First());
            return type;
        }
    }
}
