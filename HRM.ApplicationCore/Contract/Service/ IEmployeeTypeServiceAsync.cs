using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HRM.ApplicationCore.Model;

namespace HRM.ApplicationCore.Contract.Service
{
    public interface  IEmployeeTypeServiceAsync
    {
         Task<int> AddEmployeeTypeAsync( EmployeeTypeRequestModel model);
        Task<int> UpdateCandidateAsync(EmployeeTypeRequestModel model);
        Task<int> DeleteCandidateAsync(int id);
        Task<EmployeeTypeResponseModel> GetCandidateByIdAsync(int id);
        Task<IEnumerable<EmployeeTypeResponseModel>> GetAllEmployeeType();
    }
}