using TodoApp.Core.Contexts.TodoContext.Entities;

namespace TodoApp.Core.Contexts.TodoContext.UseCases.Create.Contracts;
public interface IRepository
{
    Task SaveAsync(Todo todo);
}