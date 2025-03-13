using Makani.Repositories.Interfaces;

namespace Makani.Repositories.Implements
{
    public class RoleRepository : IRoleRepository
    {
        public Task Create(Role entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Role>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Role> GetById(int? id)
        {
            throw new NotImplementedException();
        }

        public Task Update(Role entity)
        {
            throw new NotImplementedException();
        }
    }
}
