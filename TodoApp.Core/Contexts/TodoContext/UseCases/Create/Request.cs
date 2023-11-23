using MediatR;

namespace TodoApp.Core.Contexts.TodoContext.UseCases.Create;
public record Request(string Title, bool IsComplete) : IRequest<Response>;