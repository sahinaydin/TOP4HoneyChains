using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TOP4HoneyChains.Repository.Abstract
{
    public interface IDatabaseBusiness<T> where T : class
    {
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Delete(int id);
        List<T> GetAll();
        List<T> GetAll(Expression<Func<T,bool>> expression);
        T GetById(int id);
        T Get(Expression<Func<T, bool>> expression);
    }
}
