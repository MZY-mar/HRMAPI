using HRM.ApplicationCore.Contract.Repository;
using HRM.ApplicationCore.Entity;
using HRM.Infrastructure.Data;

namespace HRM.Infrastructure.Repository
{
    public class CandidateRepository : BaseRepository<Candidate>,ICandidateRepository
    {
        public CandidateRepository(HRMDbContext context) : base(context)
        {
        }
    }
}