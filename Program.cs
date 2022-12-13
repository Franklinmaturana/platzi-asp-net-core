using Microsoft.EntityFrameworkCore;
using platzi_asp_net_core.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<EscuelaContext>(options => options.UseInMemoryDatabase("testDB"));
var app = builder.Build();
var scope = app.Services.CreateScope();//capturar los servicios 
var services = scope.ServiceProvider;
try
{
    var context = services.GetRequiredService<EscuelaContext>();
    context.Database.EnsureCreated();
}
catch (Exception ex)
{
    var logger = services.GetRequiredService<ILogger<Program>>();//Requiriendo el servicio de Logg
    logger.LogError(ex, "Ocurrio un error");
}


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Escuela}/{action=Index}/{id?}");

app.Run();
