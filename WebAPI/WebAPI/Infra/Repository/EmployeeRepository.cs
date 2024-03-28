using Microsoft.EntityFrameworkCore;
using WebAPI.Model;
using WebAPI.Repository.Interfaces;

namespace WebAPI.Infra.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        
        private readonly ConnectionContext _context = new ConnectionContext();
        public void Add(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
        }

        public List<Employee> GetAll()
        {
            return _context.Employees.ToList();
        }
    }
}
