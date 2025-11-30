using Microsoft.EntityFrameworkCore;
using TodoServerApp.Data.Interfaces;

namespace TodoServerApp.Data.Services
{
    public class MSSQLDataService(ApplicationDbContext context) : IDataService
    {
        public async Task<IEnumerable<TaskIten>> GetAllAsync()
        {
            return await context.TaskItens.ToArrayAsync();
        }

        public async Task SaveAsync(TaskIten taskIten)
        {
            if (taskIten.Id == 0)
            {
                taskIten.CreatedDate = DateTime.Now;
                await context.TaskItens.AddAsync(taskIten);
            }
            else
            {
                context.TaskItens.Update(taskIten);
            }
            await context.SaveChangesAsync();
        }
        public async Task DeleteAsync(int id)
        {
            var taskIten = await context.TaskItens.FirstAsync(x => x.Id == id);
            context.TaskItens.Remove(taskIten);
            await context.SaveChangesAsync();
        }
        public async Task<TaskIten> GetTaskAsync(int id)
        {
            return await context.TaskItens.FirstAsync(x => x.Id == id);
        }
    }
}
