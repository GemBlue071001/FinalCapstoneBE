using Application.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Infrastructure;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExcelFileController : ControllerBase
    {
        private readonly IExcelFileHandling _service;
        private readonly AppDbContext _dbContext;

        public ExcelFileController(IExcelFileHandling service, AppDbContext dbContext)
        {
            _service = service;
            _dbContext = dbContext;
        }

        [HttpGet("export")]
        public async Task<IActionResult> ExportToExcel()
        {

            var employees = await _dbContext.Campaigns.ToListAsync();


            var stream = _service.CreateExcelFile(employees);


            string excelName = $"Employees-{Guid.NewGuid()}.xlsx";


            return File(stream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", excelName);
        }
    }
}
