using Domain.Entities;
using HelpDesk.Api.Repository.Interfaces;
using Hospital_Mgt_Infrastructure.BaseRepositories;

namespace Hospital_Mgt_Infrastructure.Repositories
{
    internal sealed class ProblemRepository: RepositoryBase<Problem>, IProblemsRepository
    {
        public ProblemRepository(RepositoryContext repositoryContext): base(repositoryContext)
        {
            
        }

        public Task<Problem> GetProblemById(int id)
        {
            return GetProblemById(id);
        }

        public async Task<IEnumerable<Problem>> GetProblems()
        {
            return await GetProblems();
        }

        public async Task ReportProblem(Problem problem)
        {
             await ReportProblem(problem);    
        }

        public Task UpdateProblemReported(Problem problem)
        {
            return Task.FromResult(problem);
        }
    }
}
