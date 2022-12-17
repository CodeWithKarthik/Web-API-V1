using System.ComponentModel.DataAnnotations;

namespace Jeevithaproject.Models
{
    public class SchoolDetails
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        [Range (1,2000)]
        public int Capacity { get; set; }
    }
}
