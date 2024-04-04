using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Jet_Piranha.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<StoreContext>(options => options.UseSqlite("Data Source=../Registrar.sqlite",
b => b.MigrationsAssembly("Jet.Piranha.Api") )
);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseRouting();

// Use authorization if needed. For now, it's commented out since your controller doesn't seem to require it.
// app.UseAuthorization();

// Map controllers to the application's request pipeline.
app.MapControllers();

app.Run(); // This runs the application and listens for incoming HTTP requests.
