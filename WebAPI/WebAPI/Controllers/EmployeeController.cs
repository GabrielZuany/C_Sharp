using Microsoft.AspNetCore.Authorization;
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

        [Authorize]
        [HttpPost("add-employee")]
        public IActionResult Add([FromForm]EmployeeViewModel employeeView)
        {
            var filePath = Path.Combine("Storage", employeeView.Photo.FileName);
            using Stream fileStream = new FileStream(filePath, FileMode.Create);
            employeeView.Photo.CopyTo(fileStream);

            var employee = new Employee(employeeView.Fullname, employeeView.Age, employeeView.Postalcode, filePath);
            _employeeRepository.Add(employee);
            return Ok();
        }

        [Authorize]
        [HttpPost("{id}/download-photo")]
        public IActionResult DownloadPhoto(Guid id)
        {
            var employee = _employeeRepository.Get(id);
            var dataBytes = System.IO.File.ReadAllBytes(employee.Photo);

            return File(dataBytes, "image/jpeg");
        }

        [Authorize]
        [HttpGet("get-employee")]
        public IActionResult GetAll()
        {
            var employees = _employeeRepository.GetAll();
            return Ok(employees);
        }
    }
}
