using Makani.DbContext;
using Makani.Repositories.Interfaces;

namespace Makani.Repositories.Implements
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly MakaniDbContext _context;

        public EmployeeRepository(MakaniDbContext context)
        {
            _context = context;
        }
        public Task Create(Employee entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Employee>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Employee> GetById(int? id)
        {
            throw new NotImplementedException();
        }

        public Task Update(Employee entity)
        {
            throw new NotImplementedException();
        }
    }
}
