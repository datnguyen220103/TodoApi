using TodoApi.Models;

namespace TodoApi.Services
{
    public interface ITodoService
    {
        Task<IEnumerable<TodoItem>> GetAllAsync();
        Task<TodoItem?> GetByIdAsync(long id);
        Task<TodoItem> CreateAsync(TodoItem newItem);
        Task UpdateAsync(TodoItem updatedItem);
        Task DeleteAsync(long id);
    }
}
