using BasicCompanyWebAPI.Data;
using BasicCompanyWebAPI.Entities;
using BasicCompanyWebAPI.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasicCompanyWebAPI.Services
{
    public class ContactService : IContactService
    {
        private readonly BasicCompanyDbContext _db;
        public ContactService(BasicCompanyDbContext db)
        {
            _db = db;
        }
        public int Create(Contact contact)
        {
            _db.Contacts.Add(contact);
            var res = _db.SaveChanges();
            return res;
        }

        public void Delete(int id)
        {
            var del = _db.Contacts.Where(x => x.ContactId == id).FirstOrDefault();
            _db.Contacts.Remove(del);
            _db.SaveChanges();
        }

        public List<Contact> FilterContact(int countryId, int companyId)
        {
            return _db.Contacts.Where(x => x.CountryId == countryId && x.CompanyId == companyId).ToList();
        }

        public List<Contact> Get()
        {
            return _db.Contacts.ToList();
        }

        public Contact Get(int id)
        {
            return _db.Contacts.Where(x => x.ContactId == id).FirstOrDefault();
        }

        public Contact GetContactWithCompanyAndCountry()
        {
            Contact contact = _db.Contacts.FirstOrDefault();
            contact.Company = _db.Companies.Where(c => c.CompanyId == contact.CompanyId).FirstOrDefault();
            contact.Country = _db.Countries.Where(c => c.CountryId == contact.CountryId).FirstOrDefault();
            return contact;
        }

        public Contact Update(Contact contact)
        {
            var com = _db.Contacts.Update(contact);
            _db.SaveChanges();
            return com.Entity;
        }
    }
}
