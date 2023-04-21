using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HRM.ApplicationCore.Contract.Repository;
using HRM.ApplicationCore.Contract.Service;
using HRM.ApplicationCore.Model;
using HRM.ApplicationCore.Entity;

namespace HRM.Infrastructure.Repository
{
    public class EmployeeTypeServiceAsync : IEmployeeTypeServiceAsync
    {
       private readonly IEmployeeTypeRepository _repository;

       public EmployeeTypeServiceAsync (IEmployeeTypeRepository repository){
                _repository = repository;
       }
        public async Task<int> AddEmployeeTypeAsync(EmployeeTypeRequestModel model)
        {
            EmployeeType entity = new EmployeeType(
                TypeName = model.TypeName
            );
        }

        public Task<int> DeleteCandidateAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<EmployeeTypeResponseModel>> GetAllEmployeeType()
        {
            throw new NotImplementedException();
        }

        public Task<EmployeeTypeResponseModel> GetCandidateByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateCandidateAsync(EmployeeTypeRequestModel model)
        {
            throw new NotImplementedException();
        }
    }
}