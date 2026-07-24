namespace Data_Access_Layer.Repository.Interfaces
{
    public interface ITransactionManager
    {
        Task BeginTransactionAsync();
        Task CommitAsync();
        Task RollbackAsync();
    }

}
