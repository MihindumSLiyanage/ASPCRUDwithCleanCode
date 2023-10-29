using ASPCRUDwithReactJS.Data;
using ASPCRUDwithReactJS.Model;
using ASPCRUDwithReactJS.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ASPCRUDwithReactJS.Repository
{
    public class EmployeeRepo : IEmployeeRepo
    {
        private readonly ApplicationDbContext _dbContext;

        public EmployeeRepo(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Employee> AddEmployee(Employee employee)
        {
            await _dbContext.Employees.AddAsync(employee);
            await _dbContext.SaveChangesAsync();
            return employee;
        }

        public async Task<bool> DeleteEmployee(int id)
        {
            var employee = await _dbContext.Employees.FindAsync(id);

            if (employee == null)
            {
                return false;
            }

            _dbContext.Employees.Remove(employee);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<IEnumerable<Employee>> GetAll()
        {
            return await _dbContext.Employees.ToListAsync();
        }

        public async Task<Employee> GetById(int id)
        {
            return await _dbContext.Employees.FirstOrDefaultAsync(e => e.Id == id);
        }
        public async Task<bool> UpdateEmployee(int id, Employee employee)
        {
            var existingEmployee = await _dbContext.Employees.FindAsync(id);

            if (existingEmployee == null)
            {
                return false;
            }

            existingEmployee.Name = employee.Name;
            existingEmployee.Age = employee.Age;
            existingEmployee.IsActive = employee.IsActive;

            _dbContext.Employees.Update(existingEmployee);
            await _dbContext.SaveChangesAsync();
            return true;
        }
    }
}
