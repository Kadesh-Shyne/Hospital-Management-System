using Domain.Entities;
using Microsoft.EntityFrameworkCore;


namespace Hospital_Mgt_Infrastructure.BaseRepositories
{
    public class RepositoryContext: DbContext
    {
        public RepositoryContext(DbContextOptions<RepositoryContext> options) : base(options) { }

        public DbSet<Equipment>? Equipment { get; set; }
        public DbSet<Problem>? Problem { get; set; }
        public DbSet<User>? Users { get; set; }
    }
}
