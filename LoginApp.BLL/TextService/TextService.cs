using LoginApp.CORE.Entities;
using LoginApp.CORE.Enums;
using LoginApp.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LoginApp.BLL.TextService
{
    public class TextService : ITextService
    {
        private readonly ITextDAL _repo;

        public TextService(ITextDAL repo)
        {
            _repo = repo;
        }

        public bool Any(Expression<Func<Text, bool>> expression)
        {
            return _repo.Any(expression);
        }

        public void Create(Text entity)
        {
            _repo.Create(entity);
        }

        public void Delete(Text entity)
        {
            if(entity != null)
            {
                entity.DeleteDate = DateTime.Now;
                entity.Status = Status.Passive;
                _repo.Delete(entity);
            }
        }

        public Text GetDefault(Expression<Func<Text, bool>> expression)
        {
            return _repo.GetDefault(expression);
        }

        public Text GetDefaultById(int id)
        {
            return _repo.GetDefaultById(id);
        }

        public IList<Text> GetDefaults(Expression<Func<Text, bool>> expression)
        {
            return _repo.GetDefaults(expression);
        }

        public IList<Text> GetLastTen()
        {
            return _repo.GetLastTen();
        }

        public void Update(Text entity)
        {
            if(entity != null)
            {
                entity.UpdateDate = DateTime.Now;
                entity.Status = Status.Modified;
                _repo.Update(entity);
            }
        }
    }
}
