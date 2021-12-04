using BasicCompanyWebAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasicCompanyWebAPI.Services.Interfaces
{
    public interface IContactService
    {
        List<Contact> Get();
        Contact Get(int id);
        int Create(Contact contact);
        Contact Update(Contact contact);
        void Delete(int id);
        Contact GetContactWithCompanyAndCountry();
        List<Contact> FilterContact(int countryId, int companyId);
    }
}
