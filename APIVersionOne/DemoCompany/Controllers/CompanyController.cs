using DemoCompany.Data;
using DemoCompany.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoCompany.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;
        public CompanyController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpPost]
        //access specifer return type function name
        public ActionResult Create([FromBody] Company company)
        {
            _dbContext.Companies.Add(company);
            _dbContext.SaveChanges();
            return Ok();
        }

        [HttpGet]
        public ActionResult GetAllCompanies()
        {
            List<Company> companies = _dbContext.Companies.ToList();
            return Ok(companies);
        }

        [HttpGet("{id:int}")]
        public ActionResult GetById(int id)
        {
            Company company = _dbContext.Companies.Find(id);
            return Ok(company);
        }

        [HttpPut]
        public ActionResult Update([FromBody] Company company)
        {
            _dbContext.Companies.Update(company);
            _dbContext.SaveChanges();
            return Ok();
        }

        [HttpDelete]
        public ActionResult DeleteById(int id)
        {
            Company company = _dbContext.Companies.Find(id);
            if(company != null)
            {
                _dbContext.Companies.Remove(company);
                _dbContext.SaveChanges();
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
