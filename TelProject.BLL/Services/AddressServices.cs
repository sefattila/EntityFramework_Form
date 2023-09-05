using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelProject.DAL.Concretes;
using TelProject.DAL.Context;
using TelProject.DATA.Entities;
using TelProject.DATA.Enums;

namespace TelProject.BLL.Services
{
    public class AddressServices
    {
        AddressDAL _addressDAL;
        public AddressServices()
        {
            _addressDAL = new AddressDAL();
        }

        public void Add(Address address)
        {
            _addressDAL.Add(address);
        }

        public void Delete(Address address)
        {
            address.DeletedDate = DateTime.Now;
            address.Status = Status.Passive;
            _addressDAL.Update(address);
        }

        public void Update(Address address)
        {
            address.ModifiedDate = DateTime.Now;
            address.Status = Status.Modified;
            _addressDAL.Update(address);
        }

        public Address Get(int id)
        {
            return _addressDAL.GetById(id);
        }

        public List<Address> GetAll()
        {
            return _addressDAL.GetAll();
        }

        public List<Address> GetActive(int personId)
        {
            return _addressDAL.GetActive(personId);
        }
    }
}
