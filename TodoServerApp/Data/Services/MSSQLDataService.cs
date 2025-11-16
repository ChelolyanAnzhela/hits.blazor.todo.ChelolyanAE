using Microsoft.EntityFrameworkCore;
using TodoServerApp.Data.Interfaces;

namespace TodoServerApp.Data.Services
{
    public class MSSQLDataService(ApplicationDbContext context) : IDataService
    {
        public async Task<IEnumerable<TaskIten>> GetTaskItensAsync()
        {
            return await context.TaskItens.ToArrayAsync();
        }
    }
}
