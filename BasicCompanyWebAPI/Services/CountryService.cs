using BasicCompanyWebAPI.Data;
using BasicCompanyWebAPI.Entities;
using BasicCompanyWebAPI.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasicCompanyWebAPI.Services
{
    public class CountryService : ICountryService
    {
        private readonly BasicCompanyDbContext _db;
        public CountryService(BasicCompanyDbContext db)
        {
            _db = db;
        }
        public int Create(Country country)
        {
            _db.Countries.Add(country);
            var res = _db.SaveChanges();
            return res;
        }

        public Country Update(Country country)
        {
            var com = _db.Countries.Update(country);
            _db.SaveChanges();
            return com.Entity;
        }

        public void Delete(int id)
        {
            var del = _db.Countries.Where(x => x.CountryId == id).FirstOrDefault();
            _db.Countries.Remove(del);
            _db.SaveChanges();
        }

        public List<Country> Get()
        {
            return _db.Countries.ToList();
        }

        public Country Get(int id)
        {
            return _db.Countries.Where(x => x.CountryId == id).FirstOrDefault();
        }

    }
}
