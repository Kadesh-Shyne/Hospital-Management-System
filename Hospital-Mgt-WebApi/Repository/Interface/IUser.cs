using Domain.Entities;

namespace HelpDesk.Api.Repository.Interfaces
{
    public interface IUser
    {
        Task ReportUser(User user);
        Task<IEnumerable<User>> GetUser();
        Task<User> GetUserById(int id);
        Task UpdateUserReported(User user);
    }
}
