using Flunt.Notifications;
using Flunt.Validations;

namespace TodoApp.Core.Contexts.TodoContext.UseCases.Create;
public static class Specification
{
    public static Contract<Notification> Ensure(Request request)
        => new Contract<Notification>()
            .Requires()
            .IsLowerThan(
                request.Title.Length,
                160,
                "Title",
                "A tarefa deve conter menos que 160 caracteres")
            .IsGreaterThan(
                request.Title.Length,
                3,
                "Title",
                "A tarefa deve conter mais que 3 caracteres");
}