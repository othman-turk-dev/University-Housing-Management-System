using Data_Access_Layer.Entities;

namespace Data_Access_Layer.Repository.Interfaces
{
    public interface IBankRepositry
    {
        Task<Bank> AddBankAsync(Bank bank);
        Task<Bank?> GetBankAsync(int Id);

        IQueryable<Bank> GetAllBanks();
    
    }
}
