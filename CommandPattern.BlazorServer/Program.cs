using CommandPattern.BlazorServer.Data;
using CommandPattern.BlazorServer.Services;
using MudBlazor;
using MudBlazor.Services;
using NetCore.AutoRegisterDi;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

builder.Services.AddMudServices(config =>
{
    config.SnackbarConfiguration.PositionClass = Defaults.Classes.Position.BottomCenter;

    config.SnackbarConfiguration.PreventDuplicates = false;
    config.SnackbarConfiguration.NewestOnTop = false;
    config.SnackbarConfiguration.ShowCloseIcon = true;
    config.SnackbarConfiguration.SnackbarVariant = Variant.Filled;
    config.SnackbarConfiguration.VisibleStateDuration = 2000;
    config.SnackbarConfiguration.HideTransitionDuration = 500;
    config.SnackbarConfiguration.ShowTransitionDuration = 500;
});

var env = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
var config = new ConfigurationBuilder().AddJsonFile($"appsettings.{env}.json").AddEnvironmentVariables().Build();

builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(config.GetValue<string>("AppBaseUrl")!) });
builder.Services.AddScoped(sp => new ApiServerClient(new HttpClient { BaseAddress = new Uri(config.GetValue<string>("ApiServerBaseUrl")!) }));

InjectPatternFromAssemblies(builder, "Service");

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();

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
