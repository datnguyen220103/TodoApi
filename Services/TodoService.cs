using TodoApi.Models;
using Microsoft.EntityFrameworkCore;

namespace TodoApi.Services
{
    public class TodoService : ITodoService
    {
        private readonly TodoContext _context;

        public TodoService(TodoContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<TodoItem>> GetAllAsync() => await _context.TodoItems.ToListAsync();

        public async Task<TodoItem?> GetByIdAsync(long id) => await _context.TodoItems.FindAsync(id);

        public async Task<TodoItem> CreateAsync(TodoItem newItem)
        {
            _context.TodoItems.Add(newItem);
            await _context.SaveChangesAsync();
            return newItem;
        }

        public async Task UpdateAsync(TodoItem updatedItem)
        {
            _context.Entry(updatedItem).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(long id)
        {
            var item = await _context.TodoItems.FindAsync(id);
            if (item != null)
            {
                _context.TodoItems.Remove(item);
                await _context.SaveChangesAsync();
            }
        }
    }
}
