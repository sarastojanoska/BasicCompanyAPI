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
    public class CountryController : ControllerBase
    {
        private readonly ICountryService _countryService;
        public CountryController(ICountryService countryService)
        {
            _countryService = countryService;
        }

        [HttpGet]
        [Route("GetAllCountries")]
        public List<Country> Get()
        {
            return _countryService.Get();
        }

        [HttpGet]
        [Route("Get/{id}")]
        public Country Get(int id)
        {
            return _countryService.Get(id);
        }

        [HttpPost]
        [Route("CreateCountry")]
        public int Create([FromBody] Country country)
        {
            return _countryService.Create(country);
        }

        [HttpPut]
        [Route("UpdateCountry")]
        public Country Update([FromBody] Country country)
        {
            return _countryService.Update(country);
        }

        [HttpDelete]
        [Route("DeleteCountry")]
        public void Delete(int id)
        {
            _countryService.Delete(id);
        }
    }
}
