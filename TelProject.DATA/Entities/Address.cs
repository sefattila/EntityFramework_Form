using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelProject.DATA.Abstract;

namespace TelProject.DATA.Entities
{
    public class Address : BaseEntity
    {
        public string City { get; set; }
        public string Town { get; set; }
        public string AddressDetail { get; set; }
        public int PersonId { get; set; }

        //navigation property
        public virtual Person Person { get; set; }
    }
}
