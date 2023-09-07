﻿using LoginApp.CORE.Abstract;
using LoginApp.CORE.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginApp.CORE.Entities
{
    public class Users : BaseLogin, IUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public Account Account { get; set; } = Account.PassiveUser;

        public ICollection<Text> Texts { get; set; }
    }
}