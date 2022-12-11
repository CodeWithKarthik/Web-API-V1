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

        public void AddCompany(Company company)
        {
            _dbContext.Companies.Add(company);
            _dbContext.SaveChanges();
        }

        public void UpdateCompany(Company company)
        {
            _dbContext.Update(company);
            _dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            Company company = GetById(id);
            if (company != null)
            {
                _dbContext.Companies.Remove(company);
            }
            _dbContext.SaveChanges();
        }

        public List<Company> GetAllCompany()
        {
            List<Company> companies = _dbContext.Companies.ToList();
            return companies;
        }

        public  Company GetById(int id)
        {
            Company company =  _dbContext.Companies.FirstOrDefault(x=>x.CompanyId == id);
            return company;
        }
    }
}
