using BasicCompanyWebAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasicCompanyWebAPI.Services.Interfaces
{
    public interface ICompanyService
    {
        List<Company> Get();
        Company Get(int id);
        int Create(Company company);
        Company Update(Company company);
        void Delete(int id);
    }
}
