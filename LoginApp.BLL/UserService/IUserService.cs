using LoginApp.CORE.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LoginApp.BLL.UserService
{
    public interface IUserService
    {
        void Create(User entity);
        void Update(User entity);
        void Delete(User entity);
        bool Any(Expression<Func<User, bool>> expression);
        User GetDefault(Expression<Func<User, bool>> expression);
        User GetDefaultById(int id);
        IList<User> GetDefaults(Expression<Func<User, bool>> expression);
        //...

        IList<User> GetPassive();
    }
}
