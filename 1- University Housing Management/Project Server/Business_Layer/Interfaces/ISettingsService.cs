namespace Business_Layer.Interfaces
{
    public interface ISettingsService
    {
        Task<int> GetRoomCapacityAsync();
    }
}
