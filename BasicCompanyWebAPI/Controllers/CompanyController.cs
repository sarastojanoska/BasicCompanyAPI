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
    public class CompanyController : ControllerBase
    {
        private readonly ICompanyService _companyService;
        public CompanyController(ICompanyService companyService)
        {
            _companyService = companyService;
        }

        [HttpGet]
        [Route("GetAllCompanies")]
        public List<Company> Get()
        {
            return _companyService.Get();
        }

        [HttpGet]
        [Route("Get/{id}")]
        public Company Get(int id)
        {
            return _companyService.Get(id);
        }

        [HttpPost]
        [Route("CreateCompany")]
        public int Create([FromBody] Company company)
        {
            return _companyService.Create(company);
        }

        [HttpPut]
        [Route("UpdateCompany")]
        public Company Update([FromBody] Company company)
        {
            return _companyService.Update(company);
        }

        [HttpDelete]
        [Route("DeleteCompany")]
        public void Delete (int id)
        {
             _companyService.Delete(id);
        }
    }
}
