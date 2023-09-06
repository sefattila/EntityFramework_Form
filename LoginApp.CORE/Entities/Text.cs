using LoginApp.CORE.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginApp.CORE.Entities
{
    public class Text : BaseLogin
    {
        public string TextDetail { get; set; }
        public int UserId { get; set; }

        public User User { get; set; }
    }
}
