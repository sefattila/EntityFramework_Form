using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelProject.DAL.Context;
using TelProject.DATA.Entities;
using TelProject.DATA.Enums;

namespace TelProject.DAL.Concretes
{
    public class PersonDAL
    {
        AppDbContext _dbContext;
        public PersonDAL()
        {
            _dbContext= new AppDbContext();
        }
        public void Add(Person person)
        {
            _dbContext.People.Add(person);
            _dbContext.SaveChanges();
        }

        public bool Update(Person person)
        {
            _dbContext.People.Update(person);
            return _dbContext.SaveChanges()>0; //herhangi bir satır etkilenmemiş ise 0 olucak 
        }

        public void Delete(Person person)
        {
            _dbContext.People.Remove(person);
            _dbContext.SaveChanges();
        }

        public Person GetById(int id)
        {
            return _dbContext.People.Find(id);
        }

        public List<Person> GetAll()
        {
            return _dbContext.People.ToList();
        }

        public List<Person> GetActive()
        {
            //return _dbContext.People.Include(a=>a.Addresses).Where(a => a.Status != Status.Passive).ToList(); //eager loading
            //3. bi tablo için theninclude
            return _dbContext.People.Where(a => a.Status != Status.Passive).ToList(); //lazy loading

            //eager loading
            //lazy loading
            //Explicit
        }
    }
}
