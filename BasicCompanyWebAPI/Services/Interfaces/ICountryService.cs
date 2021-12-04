using BasicCompanyWebAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasicCompanyWebAPI.Services.Interfaces
{
    public interface ICountryService
    {
        List<Country> Get();
        Country Get(int id);
        int Create(Country country);
        Country Update(Country country);
        void Delete(int id);
    }
}
