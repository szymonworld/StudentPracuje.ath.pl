using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Pracuj.Services
{
    public interface IRepositoryService<T> where T : class
    {
        IQueryable<T> GetAll();
        T GetSingle(int id);
        IQueryable<T> FindBy(Expression<Func<T, bool>> where);
        bool Edit(T entity);
        bool Add(T entity);
        bool Delete(T entity);
        bool Save();

    }
}
