using CommandPattern.Api.Repositories.Mtg;
using CommandPattern.Api.Services.Mtg.Sets;
using CommandPattern.Infrastructure;
using Microsoft.EntityFrameworkCore;
using NetCore.AutoRegisterDi;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContextFactory<CommandPatternContext>(
    opt => opt.UseSqlServer(
        builder.Configuration.GetConnectionString("CommandPattern"),
        b => b.MigrationsAssembly("CommandPattern.Api")
    )
);

InjectPatternFromAssemblies(builder, "Repository");
InjectPatternFromAssemblies(builder, "Service");

var app = builder.Build();

await EnsureDbIsMigrated(app.Services);

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

async Task EnsureDbIsMigrated(IServiceProvider services)
{
    using var scope = services.CreateScope();
    using var ctx = scope.ServiceProvider.GetService<CommandPatternContext>();
    var AspnetcoreEnvironmentValue = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
    if (ctx != null && AspnetcoreEnvironmentValue == "Development")
    {
        await ctx.Database.MigrateAsync();
    }
}

void InjectPatternFromAssemblies(WebApplicationBuilder builder, string pattern)
{
    builder.Services.RegisterAssemblyPublicNonGenericClasses(GetAssemblies("CommandPattern"))
         .Where(c => c.Name.EndsWith(pattern, StringComparison.CurrentCultureIgnoreCase))
         .AsPublicImplementedInterfaces();
}

static Assembly[] GetAssemblies(string AppName)
{
    return AppDomain.CurrentDomain.GetAssemblies()
        .Where(x => (x.FullName ?? string.Empty)
        .StartsWith(AppName, StringComparison.CurrentCultureIgnoreCase))
        .ToArray();
}
