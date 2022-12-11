using DemoCompany.Data;
using DemoCompany.Model;
using DemoCompany.Repository.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoCompany.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private ICompanyRepository _companyRepository;

        public CompanyController(ICompanyRepository companyRepository)
        {
            _companyRepository = companyRepository;
        }

        [HttpPost]
        public ActionResult Create([FromBody] Company company)
        {
            if (ModelState.IsValid)
            {
                _companyRepository.AddCompany(company);
                return Ok();
            }
            return BadRequest();
        }

        [HttpGet]
        public ActionResult GetAllCompanies()
        {
            var companies = _companyRepository.GetAllCompany();
            return Ok(companies);
        }

        [HttpGet("{id:int}")]
        public ActionResult GetById(int id)
        {
            var company = _companyRepository.GetById(id);
            return Ok(company);
        }

        [HttpPut]
        public ActionResult Update([FromBody] Company company)
        {

            if (ModelState.IsValid)
            {
                _companyRepository.UpdateCompany(company);
                return Ok();
            }
            return BadRequest();
        }

        [HttpDelete]
        public ActionResult DeleteById(int id)
        {
            _companyRepository.Delete(id);
            return Ok();
        }
    }
}
