using Data_Access_Layer.Entities;

namespace Data_Access_Layer.Repository.Interfaces
{
    public interface ISpecializationRepositry
    {

        Task<Specialization?> GetByIdAsync(int id);
        Task<Specialization?> GetByNameAsync(string name);
        Task<bool> IsExistByIdAsync(int id);
        IQueryable<Specialization> GetAll();

    }
}
