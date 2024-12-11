using FastEndpoints;
using FastEndpoints.Swagger;
using Microsoft.EntityFrameworkCore;
using ScoutManager.Database;

var bld = WebApplication.CreateBuilder();
bld.Services.AddFastEndpoints();
bld.Services.SwaggerDocument();

// bld.Services.AddDbContextFactory<ScoutManagerContext>(options =>
// {
//     options.UseNpgsql("Host=localhost;Port=5432;Database=ScoutManager;Username=postgres;Password=postgres");
// });

bld.Services.AddDbContext<ScoutManagerContext>();

var app = bld.Build();
app.UseFastEndpoints();
app.UseSwaggerGen();
app.Run();