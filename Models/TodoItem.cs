public class TodoItem
{
    public long Id { get; set; }
    public string Name { get; set; }
    public string Group { get; set; } // Nhóm CV
    public bool IsComplete { get; set; }
    public int Priority { get; set; } // Độ ưu tiên
    public DateTime DueDate { get; set; } // deadline
    public DateTime CreatedDate { get; set; } = DateTime.Now;
}
