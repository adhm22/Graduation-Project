using Makani.DbContext;
using Makani.Repositories.Interfaces;

namespace Makani.Repositories.Implements
{
    public class HouseRepository : IHouseRepository
    {
        private readonly MakaniDbContext _context;

        public HouseRepository(MakaniDbContext context)
        {
            _context = context;
        }
        public Task Create(House entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<House>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<House> GetById(int? id)
        {
            throw new NotImplementedException();
        }

        public Task Update(House entity)
        {
            throw new NotImplementedException();
        }
    }
}
