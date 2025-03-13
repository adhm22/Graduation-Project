using Makani.DbContext;
using Makani.Repositories.Interfaces;

namespace Makani.Repositories.Implements
{
    public class OwnerRepository : IOwnerRepository
    {
        private readonly MakaniDbContext _context;

        public OwnerRepository(MakaniDbContext context)
        {
            _context = context;
        }
        public Task Create(Owner entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Owner>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Owner> GetById(int? id)
        {
            throw new NotImplementedException();
        }

        public Task Update(Owner entity)
        {
            throw new NotImplementedException();
        }
    }
}
