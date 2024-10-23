namespace TodoApi.Models;

public class TodoItem
{
    public long Id { get; set; }
    public string? Name { get; set; }
    public bool IsComplete { get; set; }
    public int Priority { get; set; }  // 1 = cao, 2 = trung bình, 3 = thấp
    public DateTime? DueDate { get; set; }
}

public class TodoItemDTO
{
    public long Id { get; set; }
    public string? Name { get; set; }
    public bool IsComplete { get; set; }
    public int Priority { get; set; }
    public DateTime? DueDate { get; set; }
}