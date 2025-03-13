using Makani.DbContext;
using Makani.Repositories.Interfaces;

namespace Makani.Repositories.Implements
{
    public class TransactionRepository : ITransactionRepository
    {
        private readonly MakaniDbContext _context;

        public TransactionRepository(MakaniDbContext context)
        {
            _context = context;
        }
        public Task Create(Transaction entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Transaction>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Transaction> GetById(int? id)
        {
            throw new NotImplementedException();
        }

        public Task Update(Transaction entity)
        {
            throw new NotImplementedException();
        }
    }
}
