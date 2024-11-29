using Microsoft.AspNetCore.Mvc;
using TaskManagementService.Data;

namespace TaskManagementService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompaniesController : ControllerBase
    {
        private readonly ApplicationDb _db;
        public CompaniesController(ApplicationDb db)
        {
            _db = db;   
        }

        [HttpGet ("get-all")]
        public IActionResult GetAll()
        {
            return Ok(_db.CompaniesTable.ToList());
        }
    }
}
