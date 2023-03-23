using Domain.Entities;
using HelpDesk.Api.Data;
using HelpDesk.Api.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Hospital_Mgt_WebApi.Repository
{
    public class UserRepository : IUser
    {
        private RepositoryContext _context;
        public UserRepository(RepositoryContext context)
        {
            context = _context;
        }
        public async Task<IEnumerable<User>> GetUser()
        {
            var getUser = await _context.Users.ToListAsync();
            return getUser;
        }

        public async  Task<User> GetUserById(int id)
        {
            if (id == 0)
                return null;
            var getUserById = await _context.Users.FindAsync(id);
            return getUserById;
        }

        public async Task ReportUser(User user)
        {
           if(user == null)
                throw new ArgumentNullException("user");
           var reportUser = await _context.AddAsync(user);
        }

        public async Task UpdateUserReported(User user)
        {
            if (user is null) throw new ArgumentNullException(nameof(user));
            _context.Update(user);

            await _context.SaveChangesAsync();
        }
    }
}
