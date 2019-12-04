using DAL.Interface;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly IDbContext _dbContext;
        public Repository(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Add(TEntity entity)
        {
            _dbContext.Set<TEntity>().Add(entity);
            _dbContext.SaveChanges();

        }

        public void AddRange(ICollection<TEntity> entities)
        {
            _dbContext.Set<TEntity>().AddRange(entities);
            _dbContext.SaveChanges();
        }

        public void Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public TEntity FirstOrDefault(Expression<Func<TEntity, bool>> expression)
        {
            return _dbContext.Set<TEntity>().FirstOrDefault(expression);
        }

        public TEntity GetById(int id)
        {
            var rst = _dbContext.Set<TEntity>().Find(id);
            return rst;
        }

        public IQueryable<TEntity> GetMany(Expression<Func<TEntity, bool>> expression)
        {
            var query = _dbContext.Set<TEntity>().Where(expression);
            return query;
        }

        public void Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
