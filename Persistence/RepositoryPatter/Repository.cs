using Domain.Layer.Models;
using Microsoft.EntityFrameworkCore;
using Persistence.Layer._DbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Layer.RepositoryPatter
{
   public class Repository<T> : IRepository<T> where T : BaseEntity
    {

        private ApplicationDbContext applicationDbContext;
        private DbSet<T> entities;

        public Repository(ApplicationDbContext _applicationDbContext)
        {
            applicationDbContext = _applicationDbContext;
            entities = applicationDbContext.Set<T>();
        }

        public void Delete(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Remove(entity);
            applicationDbContext.SaveChanges();

        }

        public T GetById(int id)
        {
            return entities.SingleOrDefault(x => x.Id == id);
        }

        public IEnumerable<T> GetAll()
        {
            return entities.AsEnumerable();
        }

        public void Insert(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Add(entity);
            applicationDbContext.SaveChanges();
        }

        public void Remove(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            applicationDbContext.SaveChanges();
        }

        public void Update(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");

            }
            entities.Update(entity);
            applicationDbContext.SaveChanges();
        }

    
    }
}
