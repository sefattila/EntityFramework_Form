using LoginApp.CORE.Entities;
using LoginApp.CORE.Enums;
using LoginApp.DAL.Context;
using LoginApp.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginApp.DAL.Concretes
{
    public class UserDAL : BaseDAL<Users>, IUserDAL
    {
        private readonly AppDbContext _context;
        public UserDAL(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public IList<Users> GetPassive()
        {
            return _context.Users.Where(x => x.Status == Status.Active && x.Account == Account.PassiveUser).ToList();
        }
    }
}
