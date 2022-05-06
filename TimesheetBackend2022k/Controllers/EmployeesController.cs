using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TimesheetBackend2022k.Models;

namespace TimesheetBackend2022k.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly tuntidbContext db = new tuntidbContext();


        [HttpGet]
        public List<Employee> GetAllActive()
        {
            var employees = db.Employees.Where(e => e.Active == true);

            return employees.ToList();
        }

    }
}
