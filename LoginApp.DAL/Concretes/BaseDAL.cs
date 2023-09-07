using LoginApp.CORE.Abstract;
using LoginApp.DAL.Context;
using LoginApp.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LoginApp.DAL.Concretes
{
    public class BaseDAL<T> : IBaseDAL<T> where T : BaseLogin
    {
        private readonly AppDbContext _context;
        private DbSet<T> _table;

        public BaseDAL(AppDbContext context)
        {
            this._context = context;
            this._table=context.Set<T>();
        }

        public bool Any(Expression<Func<T, bool>> expression)
        {
            return _table.Any(expression);
        }

        public void Create(T entity)
        {
            _table.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(T entity)
        {
            _context.SaveChanges();
        }

        public T GetDefault(Expression<Func<T, bool>> expression)
        {
            return _table.FirstOrDefault(expression);
        }

        public T GetDefaultById(int id)
        {
            return _table.Find(id);
        }

        public IList<T> GetDefaults(Expression<Func<T, bool>> expression)
        {
            return _table.Where(expression).ToList();
        }

        public void Update(T entity)
        {
            _context.Entry<T>(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
