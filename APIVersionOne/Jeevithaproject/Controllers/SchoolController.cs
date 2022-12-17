using Jeevithaproject.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Jeevithaproject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SchoolController : ControllerBase
    {
        private readonly SchoolDbContext _dbContext;
        public SchoolController(SchoolDbContext dbContext)
        {
            _dbContext = dbContext;
        }

    }
}
