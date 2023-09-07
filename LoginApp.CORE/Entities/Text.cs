using LoginApp.CORE.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginApp.CORE.Entities
{
    public class Text : BaseLogin
    {
        [Column(TypeName = "text")]
        [MaxLength(300)]
        public string Title { get; set; }
        public string TextDetail { get; set; }
        public int UserId { get; set; }

        public Users User { get; set; }
    }
}
