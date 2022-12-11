using DemoCompany.Model;

namespace DemoCompany.Repository.IRepository
{
    public interface ICompanyRepository
    {
        void AddCompany(Company company);
        List<Company> GetAllCompany();
        Company GetById(int id);
        void UpdateCompany(Company company);
        void Delete(int id);
    }
}
