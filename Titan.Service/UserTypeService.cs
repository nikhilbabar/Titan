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
        public UserTypeService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _repository = _unitOfWork.GetRepository<UserType>();
        }

        public async Task<List<UserTypeModel>> GetAsync()
        {
            var types = _repository.Get().Select(x => new UserTypeModel
            {
                Id = x.Id,
                Name = x.Name,
                Code = x.Code
            }).ToList();

            return await Task.FromResult(types);
        }

        public Task<UserTypeModel> GetAsync(byte id)
        {
            throw new NotImplementedException();
        }
    }
}
