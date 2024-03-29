using Microsoft.AspNetCore.Mvc;
using WebAPI.Model;
using WebAPI.Repository.Interfaces;
using WebAPI.ViewModel;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/v1/employee")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository ?? throw new ArgumentNullException(nameof(employeeRepository));
        }

        [HttpPost]
        public IActionResult Add([FromBody]EmployeeViewModel employeeView)
        {
            var employee = new Employee(employeeView.Fullname, employeeView.Age, employeeView.Postalcode);
            _employeeRepository.Add(employee);
            return Ok();
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var employees = _employeeRepository.GetAll();
            return Ok(employees);
        }
    }
}
