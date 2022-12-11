using DemoCompany.Data;
using DemoCompany.Model;
using DemoCompany.Repository.IRepository;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace DemoCompany.Repository
{
    public class CompanyRepository : ICompanyRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public CompanyRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Company> AddCompany(Company company)
        {
            _dbContext.Companies.Add(company);
            await _dbContext.SaveChangesAsync();
            return company;
        }

        public async Task Delete(int id)
        {
            Company company = _dbContext.Companies.Find(id);
            if(company != null) 
            {
                _dbContext.Companies.Remove(company);
            }
            _dbContext.SaveChanges();
        }

        public async Task<List<Company>> GetAllCompany()
        {
            List<Company> companies = _dbContext.Companies.ToList();
            return companies;
        }

        public async Task<Company> GetById(int id)
        {
            Company company = _dbContext.Companies.Find(id);
            return company;
        }

        public async Task<Company> UpdateCompany(Company company)
        {
            _dbContext.Update(company);
            _dbContext.SaveChanges();
            return company;
        }
    }
}
