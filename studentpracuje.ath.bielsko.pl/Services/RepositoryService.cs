using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Pracuj.Models;

namespace Pracuj.Services
{

    public class RepositoryService<T> : IRepositoryService<T> where T : class, IEntity<int>
    {
        protected DbContext _context;
        private DbSet<T> Set;

        public RepositoryService(DbContext context)
        {
            _context = context;
            Set = (_context as DbContext).Set<T>();
        }

        public virtual bool Add(T entity)
        {
            bool result;
            try
            {
                Set.Add(entity);
                result = Save();
            }
            catch (Exception e)
            {
                result = false;
            }

            return result;
        }

        public virtual bool Delete(T entity)
        {
            bool result;
            try
            {
                Set.Remove(entity);
                result = Save();
            }
            catch (Exception e)
            {
                result = false;
            }
            return result;
        }

        public virtual bool Edit(T entity)
        {
            bool result;
            try
            {
                (_context as DbContext).Entry(entity).State = System.Data.Entity.EntityState.Modified;
                result = Save();
            }
            catch (Exception e)
            {
                result = false;
            }
            return result;
        }

        public virtual IQueryable<T> FindBy(Expression<Func<T, bool>> where)
        {
            return Set.Where(where);
        }

        public virtual IQueryable<T> GetAll()
        {
            return Set;
        }

        public virtual T GetSingle(int id)
        {

            var result = Set.FirstOrDefault(r => r.Id == id);

            return result;
        }

        public virtual bool Save()
        {
            bool result;
            try
            {
                ((DbContext)_context).SaveChanges();
                result = true;
            }
            catch (Exception e)
            {
                result = false;
            }

            return result;

        }
    }
}

