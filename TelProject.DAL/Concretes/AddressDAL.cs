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
    public class AddressDAL
    {
        AppDbContext _dbContext;
        public AddressDAL()
        {
            _dbContext = new AppDbContext();
        }

        public void Add(Address address)
        {
            _dbContext.Add(address);
            _dbContext.SaveChanges();
        }

        public void Update(Address address)
        {
            _dbContext.Update(address);
            _dbContext.SaveChanges();
        }

        public void Delete(Address address)
        {
            _dbContext.Remove(address);
            _dbContext.SaveChanges();
        }

        public Address GetById(int id)
        {
            return _dbContext.Addresses.Find(id);
        }

        public List<Address> GetAll()
        {
            return _dbContext.Addresses.ToList();
        }

        public List<Address> GetActive(int personId)
        {
            return _dbContext.Addresses.Where(x => x.PersonId == personId && x.Status != Status.Passive).ToList();
        }
    }
}
