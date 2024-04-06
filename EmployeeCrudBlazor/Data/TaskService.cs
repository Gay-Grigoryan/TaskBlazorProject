
using EmployeeCrudBlazor.DataContext;
using EmployeeCrudBlazor.Models;
using Microsoft.EntityFrameworkCore;
namespace EmployeeCrudBlazor.Data
{
    public class TaskService
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public TaskService(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public async Task<List<ToDo>> GetAllTasks()
        {
            return await _applicationDbContext.Employees.ToListAsync();
        }
        public async Task<bool> InsertTask(Models.ToDo task)
        {
            await _applicationDbContext.Employees.AddAsync(task);
            await _applicationDbContext.SaveChangesAsync();
            return true;
        } 
        public async Task<ToDo> GetTaskById(int id)
        {
            Models.ToDo task = await _applicationDbContext.Employees.FirstOrDefaultAsync(c => c.Id.Equals(id));
            return task;
        }
        public async Task<bool> UpdateTask(Models.ToDo task)
        {
            _applicationDbContext.Employees.Update(task);
            await _applicationDbContext.SaveChangesAsync();
            return true;
        }
        public async Task<bool> DeleteTask(Models.ToDo task)
        {
            _applicationDbContext.Employees.Remove(task);
            await _applicationDbContext.SaveChangesAsync();
            return true;
        }
        public async Task<List<ToDo>> GetTasksForToday()
        {
            DateTime today = DateTime.Today;
            return await _applicationDbContext.Employees.Where(t => t.TaskDate.Date == today).ToListAsync();
        }


    }
}