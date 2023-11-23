using TodoApp.Api.Extensions;

var builder = WebApplication.CreateBuilder(args);
builder.AddConfiguration();
builder.AddDatabase();
builder.AddTodoContext();
builder.AddMediator();

var app = builder.Build();
app.MapTodoEndpoints();

app.Run();
