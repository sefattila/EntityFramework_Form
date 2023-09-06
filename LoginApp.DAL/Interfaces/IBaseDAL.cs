using LoginApp.CORE.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LoginApp.DAL.Interfaces
{
    public interface IBaseDAL<T> where T : BaseLogin
    {
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
        bool Any(Expression<Func<T, bool>> expression);
        T GetDefault(Expression<Func<T, bool>> expression);
        T GetDefaultById(int id);
        IList<T> GetDefaults(Expression<Func<T, bool>> expression);
    }
}
