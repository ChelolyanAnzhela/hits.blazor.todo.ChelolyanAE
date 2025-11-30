namespace TodoServerApp.Data.Interfaces
{
    public interface IDataService
    {
        Task<IEnumerable<TaskIten>> GetAllAsync();
        Task SaveAsync(TaskIten iten);
        Task<TaskIten> GetTaskAsync(int id);
        Task DeleteAsync(int id);
    }
}
