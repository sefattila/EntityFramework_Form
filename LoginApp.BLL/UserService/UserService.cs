using LoginApp.CORE.Entities;
using LoginApp.CORE.Enums;
using LoginApp.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
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

        public bool Any(Expression<Func<Users, bool>> expression)
        {
            return _repo.Any(expression);
        }

        public void Create(Users entity)
        {
            string format = @"^[a-zA-Z0-9]+$";
            bool isAnyNumber = entity.Password.Any(char.IsDigit);
            bool isAllCharOrDigit = !entity.Password.All(char.IsLetterOrDigit);
            bool isAnyLetter = entity.Password.Any(char.IsLetter);
            if (!Any(x => x.UserName.ToLower() == entity.UserName.ToLower()))
            {
                if (isAnyLetter && isAllCharOrDigit && isAnyNumber && entity.Password.Length > 6)
                    _repo.Create(entity);
                else throw new Exception("Şifre Özel Karakter, Sayı İçermeli ve 6 Karakterden Fazla Olmalı");
            }
            else throw new Exception("Aynı Kullanıcı Adı Mevcut");
        }

        public void Delete(Users entity)
        {
            if (GetDefaultById(entity.Id) != null)
            {
                entity.DeleteDate = DateTime.Now;
                entity.Status = Status.Passive;
                _repo.Delete(entity);
            }
            else throw new Exception("Böyle Bir Kullanıcı Yok");
        }

        public Users GetDefault(Expression<Func<Users, bool>> expression)
        {
            return _repo.GetDefault(expression);
        }

        public Users GetDefaultById(int id)
        {
            return _repo.GetDefaultById(id);
        }

        public IList<Users> GetDefaults(Expression<Func<Users, bool>> expression)
        {
            return _repo.GetDefaults(expression);
        }

        public IList<Users> GetPassive()
        {
            return _repo.GetPassive();
        }

        public Users GetUser(string username, string password)
        {
            Users _user = _repo.GetDefault(x => x.UserName == username && x.Status == Status.Active);
            if (_user == null)
            {
                throw new Exception("Böyle Bir Kullanıcı Yok veya Silnmiş Hesap");
            }

            if (_user.Password != password)
            {
                throw new Exception("Şifre Yanlış");
            }

            if (_user.Account == Account.PassiveUser)
            {
                throw new Exception("Hesabınız Onaylanmamış");
            }
            return _user;
        }


        public void Update(Users entity)
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
