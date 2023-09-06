using LoginApp.CORE.Abstract;
using LoginApp.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LoginApp.DAL.Concretes
{
    public class BaseDAL<T> : IBaseDAL<T> where T : BaseLogin
    {
        public bool Any(Expression<Func<T, bool>> expression)
        {
            return false;
        }

        public void Create(T entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public T GetDefault(Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public T GetDefaultById(int id)
        {
            throw new NotImplementedException();
        }

        public IList<T> GetDefaults(Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
