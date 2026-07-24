using Data_Access_Layer.Data;
using Data_Access_Layer.Repository.Interfaces;
using Microsoft.EntityFrameworkCore.Storage;

namespace Data_Access_Layer.Repository.Implementaions
{
    public class TransactionManager: ITransactionManager
    {
        private readonly AppDbContext _context;
        private IDbContextTransaction? _transaction;

        public TransactionManager(AppDbContext context)
            => _context = context;

        public async Task BeginTransactionAsync()
            => _transaction = await _context.Database.BeginTransactionAsync();

        public async Task CommitAsync()
        {
            if (_transaction != null)
                await _transaction.CommitAsync();
        }

        public async Task RollbackAsync()
        {
            if (_transaction != null)
                await _transaction.RollbackAsync();
        }
    }
}
