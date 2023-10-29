using ASPCRUDwithReactJS.Model;
using ASPCRUDwithReactJS.Repository.IRepository;

namespace ASPCRUDwithReactJS.Service
{
    public class EmployeeService
    {
        private readonly IEmployeeRepo _employeeRepo;

        public EmployeeService(IEmployeeRepo employeeRepo)
        {
            _employeeRepo = employeeRepo;
        }

        public async Task<Employee> GetByIdAsync(int id)
        {
            return await _employeeRepo.GetById(id);
        }

        public async Task<IEnumerable<Employee>> GetAllAsync()
        {
            return await _employeeRepo.GetAll();
        }

        public async Task AddAsync(Employee employee)
        {
            await _employeeRepo.AddEmployee(employee);
        }

        public async Task UpdateAsync(int id, Employee employee)
        {
            await _employeeRepo.UpdateEmployee(id, employee);
        }

        public async Task DeleteAsync(int id)
        {
            await _employeeRepo.DeleteEmployee(id);
        }
    }
}
