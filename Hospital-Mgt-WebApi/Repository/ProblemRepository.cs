using Domain.Entities;
using HelpDesk.Api.Data;
using HelpDesk.Api.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HelpDesk.Api.Repository
{
    public class ProblemRepository : IProblemsRepository
    {
        private RepositoryContext _context;

        public ProblemRepository(RepositoryContext context)
        {
            _context = context;
        }

        public async Task<Problem> GetProblemById(int id)
        {
            if (id == 0)
                return null;
            var query = await _context.Problem.FindAsync(id);
            return query;
        }

        public async Task<IEnumerable<Problem>> GetProblems()
        {
            var problemsList = await _context.Problem.ToListAsync();
            return problemsList;
        }

        public async Task ReportProblem(Problem problem)
        {
            if (problem is null) throw new ArgumentNullException(nameof(problem));

            _context.AddAsync(problem);

            await _context.SaveChangesAsync();
        }

        public async Task UpdateProblemReported(Problem problem)
        {
            if (problem is null) throw new ArgumentNullException(nameof(problem));
            _context.Update(problem);

            await _context.SaveChangesAsync();
        }
    }
}
