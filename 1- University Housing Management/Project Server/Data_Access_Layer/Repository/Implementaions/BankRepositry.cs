using Data_Access_Layer.Data;
using Data_Access_Layer.Entities;
using Microsoft.EntityFrameworkCore;
using Data_Access_Layer.Repository.Interfaces;

namespace Data_Access_Layer.Repository.Implementaions
{
    public class BankRepositry: IBankRepositry
    {

        private readonly AppDbContext _context;
        public BankRepositry(AppDbContext context) => _context = context;

        public async Task <Bank> AddBankAsync(Bank bank)
        {

            await _context.AddAsync(bank);
            await _context.SaveChangesAsync();

            return bank;
        }
        public async Task<Bank?> GetBankAsync(int Id)
        {

            return await _context.Banks.FindAsync(Id);
        }
        public IQueryable<Bank> GetAllBanks()
        {

            return _context.Banks.AsNoTracking();
        }

    }
}
