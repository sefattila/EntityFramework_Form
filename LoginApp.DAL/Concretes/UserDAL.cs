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
    public class UserDAL : BaseDAL<User>, IUserDAL
    {
        private readonly AppDbContext _context;
        public UserDAL(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public IList<User> GetPassive()
        {
            return _context.Users.Where(x=>x.Status==Status.Passive).ToList();
        }
    }
}
