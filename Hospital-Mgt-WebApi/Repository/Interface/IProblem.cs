using Domain.Entities;

namespace HelpDesk.Api.Repository.Interfaces
{
    public interface IProblemsRepository
    {
        Task ReportProblem(Problem problem);
        Task<IEnumerable<Problem>> GetProblems();
        Task<Problem> GetProblemById(int id);
        Task UpdateProblemReported(Problem problem);
    }
}
