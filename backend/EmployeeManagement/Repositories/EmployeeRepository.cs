using EmployeeManagement.Data;
using EmployeeManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.Repositories
{
    public class EmployeeRepository : InterfaceRepository<Employee>
    {
        private readonly AppDbContext _context; 

        public EmployeeRepository(AppDbContext context)
        {
            _context  = context;
        }
        public async Task AddAsync(Employee t)
        {
            await _context.Employees.AddAsync(t);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var employeeInDb = await _context.Employees.FindAsync(id);

            if (employeeInDb == null) 
            {
                throw new KeyNotFoundException($"Employee id: {id} was not found.");
            }

            _context.Employees.Remove(employeeInDb);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Employee>> getAllAsync()
        {
            return await _context.Employees.ToListAsync();
        }

        public async Task<Employee?> getByIdAsync(int id)
        {
            return await _context.Employees.FindAsync( id);
        }

        public async Task UpdateAsync(Employee t)
        {
            _context.Employees.Update(t);    // Update cannot be async directly.
            await _context.SaveChangesAsync();
        }
    }
}
