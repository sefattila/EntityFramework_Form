using LoginApp.CORE.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LoginApp.DAL.Interfaces
{
    public interface ITextDAL : IBaseDAL<Text>
    {
        IList<User> GetLastTen();
    }
}
