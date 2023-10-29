using ASPCRUDwithReactJS.Model;
using Microsoft.AspNetCore.Mvc;

namespace ASPCRUDwithReactJS.Repository.IRepository
{
    public interface IEmployeeRepo
    {
        public Task<IEnumerable<Employee>> GetAll();
        public Task<Employee> GetById(int id);
        public Task<Employee> AddEmployee(Employee employee);
        public Task<bool> UpdateEmployee(int id, Employee employee);
        public Task<bool> DeleteEmployee(int id);
    }
}
