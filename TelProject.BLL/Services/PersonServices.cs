using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TelProject.DAL.Concretes;
using TelProject.DATA.Entities;
using TelProject.DATA.Enums;

namespace TelProject.BLL.Services
{
    public class PersonServices
    {
        PersonDAL _personDAL;
        public PersonServices()
        {
            _personDAL = new PersonDAL();
        }

        public void Add(Person person)
        {
            _personDAL.Add(person);
        }

        public bool Update(Person person)
        {
            person.ModifiedDate = DateTime.Now;
            person.Status = Status.Modified;
            return _personDAL.Update(person);
        }

        public void Delete(Person person)
        {
            person.Status = Status.Passive;
            person.DeletedDate = DateTime.Now;
            _personDAL.Update(person);
        }

        public Person Get(int id)
        {
            return _personDAL.GetById(id);
        }

        public List<Person> GetAll()
        {
            return _personDAL.GetAll();
        }

        public List<Person> GetActive()
        {
            return _personDAL.GetActive();
        }

        public List<Person> OrderBy<TKey>(Expression<Func<Person,TKey>> expression)
        {
            return _personDAL.OrderByASC(expression);
        }
    }
}
