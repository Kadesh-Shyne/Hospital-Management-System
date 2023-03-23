
using Hospital_Mgt_Application.Contracts;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Hospital_Mgt_Infrastructure.BaseRepositories
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected RepositoryContext _repositoryContext;
        public RepositoryBase(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
        }

        public void Create(T entity) 
            => Create(entity);

        public void Delete(T entity)
            => Delete(entity);

        public IQueryable<T> GetAll(bool trackChanges)
            => !trackChanges ?
                 _repositoryContext.Set<T>()
                 .AsNoTracking() :
                 _repositoryContext.Set<T>();

        public IQueryable<T> GetByCondition(Expression<Func<T, bool>> expression, bool trackChanges) 
            => !trackChanges ?
                 _repositoryContext.Set<T>()
                 .Where(expression)
                 .AsNoTracking() :
                 _repositoryContext.Set<T>()
                 .Where(expression);

        public void Update(T entity)
            => Update(entity);
    }
}
