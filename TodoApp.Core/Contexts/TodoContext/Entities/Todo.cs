using TodoApp.Core.Contexts.SharedContext.Entities;

namespace TodoApp.Core.Contexts.TodoContext.Entities;
public class Todo : Entity
{
    protected Todo()
    {
    }

    public Todo(string title, bool isComplete)
    {
        Title = title;
        IsComplete = isComplete;
    }

    public string Title { get; private set; } = string.Empty;
    public bool IsComplete { get; private set; } = false;
}