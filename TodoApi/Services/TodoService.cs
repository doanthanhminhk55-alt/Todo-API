using Microsoft.EntityFrameworkCore;

public class TodoService
{
    private readonly AppDbContext _context;
    public TodoService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<TodoItem>> GetAll()
    {
        return await _context.Todos.ToListAsync();
    }

    public async Task<TodoItem> Get(int id)
    {
        return await _context.Todos.FindAsync(id);
    }

    public async Task Add(TodoItem item)
    {
        _context.Todos.Add(item);
        await _context.SaveChangesAsync();
    }

    public async Task Update(int id, TodoItem item)
    {
        var existing = await _context.Todos.FindAsync(id);
        if (existing == null) return;

        existing.Title = item.Title;
        existing.IsDone = item.IsDone;

        await _context.SaveChangesAsync();
    }

    public async Task Delete(int id)
    {
        var item = await _context.Todos.FindAsync(id);
        if (item == null) return;

        _context.Todos.Remove(item);
        await _context.SaveChangesAsync();
    }
}