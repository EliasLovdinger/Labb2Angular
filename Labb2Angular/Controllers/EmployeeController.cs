using Labb2Angular.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Labb2Angular.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeRepo _Iemployee;
        private readonly IDeparmentRepo _Deparment;
        private readonly AppDbContext _appDbContext;

        public EmployeesController(IEmployeeRepo iemployee, IDeparmentRepo deparment, AppDbContext appDbContext)
        {
            _Iemployee = iemployee;
            _Deparment = deparment;
            _appDbContext = appDbContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllEmployees()
        {
            var AllEmployees = _Iemployee.GetAll.ToList();

            if (AllEmployees != null)
            {
                return Ok(AllEmployees);
            }

            return NotFound();
        }

        [HttpGet("{id:int}")]
        public IActionResult GetEmployeeById(int id)
        {
            var EmployeeById = _Iemployee.GetById(id);

            if (EmployeeById != null)
            {
                return Ok(EmployeeById);
            }

            return NotFound();
        }

        [HttpPost]
        public IActionResult AddEmployee(Employee employee)
        {
            if (employee != null)
            {
                _Iemployee.Add(employee);
                return Ok(employee);
            }
            return NotFound("Failed to add Employee");
        }
        [HttpPut]
        [Route("{id}")]
        public IActionResult UpdateEmployee(Employee employee)
        {
            if (employee != null)
            {
                _Iemployee.Update(employee);
                return Ok(employee);
            }
            return NotFound("Failed to update Employee");

         }
        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> DeleteEmployee([FromRoute]int id)
        {
            var EmployeeToDelete = _Iemployee.GetById(id);
            if (EmployeeToDelete != null)
            {
                _Iemployee.Delete(id);
                return Ok(EmployeeToDelete);
            }

            return NotFound("Employee to delete was not found");
        }
    }
}
