using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelProject.DATA.Abstract;

namespace TelProject.DATA.Entities
{
    public class Person : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }

        //navigation-property Relation
        public virtual IList<Address> Addresses { get; set; }
    }
}
