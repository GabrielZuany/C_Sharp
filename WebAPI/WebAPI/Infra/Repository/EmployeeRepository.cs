﻿using Microsoft.EntityFrameworkCore;
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

        public Employee? Get(Guid id)
        {
            return _context.Employees.Find(id);
        }

        public List<Employee> Get(int pageNumber, int pageQuantity)
        {
            return _context.Employees.Skip((pageNumber-1) * pageQuantity).Take(pageQuantity).ToList();
        }
    }
}
