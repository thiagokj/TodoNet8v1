using Microsoft.EntityFrameworkCore;
using TodoApp.Core;
using TodoApp.Infra.Data;

namespace TodoApp.Api.Extensions;
public static class BuilderExtension
{
    public static void AddConfiguration(this WebApplicationBuilder builder)
    {
        Configuration.Database.ConnectionString =
            builder.Configuration.GetConnectionString("DefaultConnection") ?? string.Empty;
    }

    public static void AddDatabase(this WebApplicationBuilder builder)
    {
        builder.Services.AddDbContext<AppDbContext>(x =>
            x.UseSqlite(
                Configuration.Database.ConnectionString,
                b => b.MigrationsAssembly("TodoApp.Api")));
    }

    public static void AddMediator(this WebApplicationBuilder builder)
    {
        builder.Services.AddMediatR(x
            => x.RegisterServicesFromAssembly(typeof(Configuration).Assembly));
    }
}