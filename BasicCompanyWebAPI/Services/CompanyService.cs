using BasicCompanyWebAPI.Data;
using BasicCompanyWebAPI.Entities;
using BasicCompanyWebAPI.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasicCompanyWebAPI.Services
{
    public class CompanyService : ICompanyService
    {
        private readonly BasicCompanyDbContext _db;
        public CompanyService(BasicCompanyDbContext db)
        {
            _db = db;
        }

        public int Create(Company company)
        {
            _db.Companies.Add(company);
            var res =_db.SaveChanges();
            return res;
        }

        public Company Update(Company company)
        {
            var com = _db.Companies.Update(company);
            _db.SaveChanges();
            return com.Entity;
        }

        public void Delete(int id)
        {
            var del = _db.Companies.Where(x => x.CompanyId == id).FirstOrDefault();
            _db.Companies.Remove(del);
            _db.SaveChanges();
        }

        public List<Company> Get()
        {
            return _db.Companies.ToList();
        }

        public Company Get(int id)
        {
            return _db.Companies.Where(x => x.CompanyId == id).FirstOrDefault();
        }

    }
}
