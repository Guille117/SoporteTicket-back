using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;

var builder = WebApplication.CreateBuilder(args);

// --- SECCIÓN DE SERVICIOS ---
builder.Services.AddControllers();
builder.Services.AddOpenApi();

// 1. Obtenemos la cadena de conexión del appsettings.json
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

// 2. CONFIGURACIÓN PARA MYSQL (Cambiado de UseSqlServer a UseMySql)
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

// --- CONFIGURACIÓN DE LA APP ---
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();