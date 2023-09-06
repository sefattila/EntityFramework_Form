using LoginApp.CORE.Abstract;
using LoginApp.CORE.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginApp.CORE.Entities
{
    public class User : BaseLogin, IUser
    {
        public User()
        {
            base.Status = Status.Passive;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public Account Acoount { get; set; } = Account.User;

        public ICollection<Text> Texts { get; set; }
    }
}
