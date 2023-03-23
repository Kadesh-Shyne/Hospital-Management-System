using Domain.Entities;
using Hospital_Mgt_Infrastructure.BaseRepositories;

namespace Hospital_Mgt_Infrastructure.Repositories
{
    internal sealed class UserRepository : RepositoryBase<User>
    {
        public UserRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {

        }

        public Task<User> GetUserById(int id)
        {
            return GetUserById(id);
        }

        public async Task<IEnumerable<User>> GetUsers()
        {
            return await GetUsers();
        }

        public async Task ReportUser (User user)
        {
            await ReportUser(user);
        }

        public Task UpdateUserReported(User user)
        {
            return Task.FromResult(user);
        }
    }
}
