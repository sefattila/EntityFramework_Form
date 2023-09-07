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
        void Create(Users entity);
        void Update(Users entity);
        void Delete(Users entity);
        bool Any(Expression<Func<Users, bool>> expression);
        Users GetDefault(Expression<Func<Users, bool>> expression);
        Users GetDefaultById(int id);
        IList<Users> GetDefaults(Expression<Func<Users, bool>> expression);
        //...

        IList<Users> GetPassive();
        //..

        Users GetUser(string username,string password);
        bool PasswordControl(string password);
    }
}
