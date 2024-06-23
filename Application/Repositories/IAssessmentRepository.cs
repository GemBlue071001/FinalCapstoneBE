using Application.Repository;
using Domain.Entities;

namespace Application.Repositories
{
    public interface IAssessmentRepository: IGenericRepository<Assessment>
    {
        Task<List<Assessment>> GetAllAssessment();
    }
}
