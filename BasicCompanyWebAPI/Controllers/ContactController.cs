using BasicCompanyWebAPI.Entities;
using BasicCompanyWebAPI.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasicCompanyWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        [HttpGet]
        [Route("GetAllContacts")]
        public List<Contact> Get()
        {
            return _contactService.Get();
        }

        [HttpGet]
        [Route("Get/{id}")]
        public Contact Get(int id)
        {
            return _contactService.Get(id);
        }

        [HttpGet]
        [Route("GetContactsWithCompanyAndCountry")]
        public Contact GetContactsWithCompanyAndCountry()
        {
            return _contactService.GetContactWithCompanyAndCountry();
        }

        [HttpGet]
        [Route("FilterContact/{countryId}/{companyId}")]
        public List<Contact> FilterContact(int countryId, int companyId)
        {
            return _contactService.FilterContact(countryId, companyId);
        }

        [HttpPost]
        [Route("CreateContact")]
        public int Create([FromBody] Contact contact)
        {
            return _contactService.Create(contact);
        }

        [HttpPut]
        [Route("UpdateContact")]
        public Contact Update([FromBody] Contact contact)
        {
            return _contactService.Update(contact);
        }

        [HttpDelete]
        [Route("DeleteContact")]
        public void Delete(int id)
        {
            _contactService.Delete(id);
        }

    }
}
