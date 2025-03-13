using Makani.DbContext;
using Makani.Repositories.Interfaces;

namespace Makani.Repositories.Implements
{
    public class PictureRepository : IPictureRepository
    {
        private readonly MakaniDbContext _context;

        public PictureRepository(MakaniDbContext context)
        {
            _context = context;
        }
        public Task Create(Picture entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Picture>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Picture> GetById(int? id)
        {
            throw new NotImplementedException();
        }

        public Task Update(Picture entity)
        {
            throw new NotImplementedException();
        }
    }
}
