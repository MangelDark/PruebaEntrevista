using Domain.Layer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Layer.RepositoryPatter
{
    public interface IRepository<T> where T : BaseEntity
    {

        IEnumerable<T> GetAll();
        T GetById(int id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Remove(T entoty);
        void SaveChanges();
        
    }
}
