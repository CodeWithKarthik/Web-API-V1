using System.ComponentModel.DataAnnotations;

namespace DemoCompany.Model
{
    //Class Name Table
    public class Company
    {
        [Key]
        public int CompanyId { get; set; }

        public string CompanyName { get; set; }

        [Range(1,1000)]
        public int NumberOfEmployee { get; set; }

        [Required]
        public string CompanyOwner { get; set; }
    }
}
