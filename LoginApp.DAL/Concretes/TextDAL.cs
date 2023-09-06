using LoginApp.CORE.Entities;
using LoginApp.DAL.Context;
using LoginApp.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginApp.DAL.Concretes
{
    public class TextDAL : BaseDAL<Text>,ITextDAL
    {
        private readonly AppDbContext _context;
        public TextDAL(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public IList<Text> GetLastTen()
        {
            return _context.Texts.Take(10).OrderBy(x=>x.CreateDate).ToList();
        }
    }
}
