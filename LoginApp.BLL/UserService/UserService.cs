using LoginApp.CORE.Entities;
using LoginApp.CORE.Enums;
using LoginApp.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LoginApp.BLL.UserService
{
    public class UserService : IUserService
    {
        private readonly IUserDAL _repo;

        public UserService(IUserDAL repo)
        {
            _repo = repo;
        }

        public bool Any(Expression<Func<User, bool>> expression)
        {
            return _repo.Any(expression);
        }

        public void Create(User entity)
        {
            if (Any(x => x.UserName != entity.UserName))
            {
                _repo.Create(entity);
            }
            else throw new Exception("Aynı Kullanıcı Adı Mevcut");
        }

        public void Delete(User entity)
        {
            if (GetDefaultById(entity.Id) != null)
            {
                entity.DeleteDate = DateTime.Now;
                entity.Status = Status.Passive;
                _repo.Delete(entity);
            }
            else throw new Exception("Böyle Bir Kullanıcı Yok");
        }

        public User GetDefault(Expression<Func<User, bool>> expression)
        {
            return _repo.GetDefault(expression);
        }

        public User GetDefaultById(int id)
        {
            return _repo.GetDefaultById(id);
        }

        public IList<User> GetDefaults(Expression<Func<User, bool>> expression)
        {
            return _repo.GetDefaults(expression);
        }

        public IList<User> GetPassive()
        {
            return _repo.GetPassive();
        }

        public void Update(User entity)
        {
            if (entity != null)
            {
                entity.UpdateDate = DateTime.Now;
                entity.Status = Status.Modified;
                _repo.Update(entity);
            }
            else throw new Exception("Güncellenecek Veri Yok");
        }
    }
}
