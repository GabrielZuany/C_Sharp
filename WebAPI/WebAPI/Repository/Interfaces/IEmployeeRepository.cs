using WebAPI.Model;

namespace WebAPI.Repository.Interfaces
{
    public interface IEmployeeRepository
    {
        void Add(Employee employee);
        List<Employee> GetAll();
    }
}
