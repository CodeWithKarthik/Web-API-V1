using DemoCompany.Model;

namespace DemoCompany.Repository.IRepository
{
    public interface ICompanyRepository
    {
        Task<Company> AddCompany(Company company);
        Task<List<Company>> GetAllCompany();
        Task<Company> GetById(int id);
        Task<Company> UpdateCompany(Company company);
        Task Delete(int id);
    }
}
