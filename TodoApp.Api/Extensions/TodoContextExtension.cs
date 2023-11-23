using MediatR;

namespace TodoApp.Api.Extensions;
public static class TodoContextExtension
{
    public static void AddTodoContext(this WebApplicationBuilder builder)
    {
        #region Create

        builder.Services.AddTransient<
            TodoApp.Core.Contexts.TodoContext.UseCases.Create.Contracts.IRepository,
            TodoApp.Infra.Contexts.TodoContext.UseCases.Create.Repository>();

        #endregion
    }

    public static void MapTodoEndpoints(this WebApplication app)
    {
        #region Create

        app.MapPost("api/v1/todos", async (
            TodoApp.Core.Contexts.TodoContext.UseCases.Create.Request request,
            IRequestHandler<
                TodoApp.Core.Contexts.TodoContext.UseCases.Create.Request,
                TodoApp.Core.Contexts.TodoContext.UseCases.Create.Response> handler) =>
        {
            var result = await handler.Handle(request, new CancellationToken());
            return result.IsSuccess
              ? Results.Created($"api/v1/todos/{result.Data?.Id}", result)
              : Results.Json(result, statusCode: result.Status);
        });

        #endregion        
    }
}