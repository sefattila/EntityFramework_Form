using LoginApp.CORE.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LoginApp.BLL.TextService
{
    public interface ITextService
    {
        void Create(Text entity);
        void Update(Text entity);
        void Delete(Text entity);
        bool Any(Expression<Func<Text, bool>> expression);
        Text GetDefault(Expression<Func<Text, bool>> expression);
        Text GetDefaultById(int id);
        IList<Text> GetDefaults(Expression<Func<Text, bool>> expression);
        //...

        IList<Text> GetLastTen();
    }
}
