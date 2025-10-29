namespace TodoServerApp.Data.Interfaces
{
    public interface IDataService
    {
        Task<IEnumerable<TaskIten>> GetTaskItensAsync();
    }
}
