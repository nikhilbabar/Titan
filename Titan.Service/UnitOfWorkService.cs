using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Titan.Repository.Interface;
using Titan.Service.Interface;

namespace Titan.Service
{
    public class UnitOfWorkService : IUnitOfWorkService
    {
        private readonly IUnitOfWork _unitOfWork;

        public UnitOfWorkService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> SaveAsync()
        {
            var result = await _unitOfWork.SaveAsync();
            return result;
        }
    }
}
