using Makani.DbContext;
using Makani.Repositories.Interfaces;

namespace Makani.Repositories.Implements
{
    public class ReviewRepository : IReviewRepository
    {
        private readonly MakaniDbContext _context;

        public ReviewRepository(MakaniDbContext context)
        {
            _context = context;
        }
        public Task Create(Review entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Review>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Review> GetById(int? id)
        {
            throw new NotImplementedException();
        }

        public Task Update(Review entity)
        {
            throw new NotImplementedException();
        }
    }
}
