using Microsoft.EntityFrameworkCore;
using RuesCore.Interfaces;
using RuesCore.Models.Entities;
using RuesCore.Services;
using RuesInfrastructure.Persistence;
using RuesInfrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<AppDbContext>(s => 
    s.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped<IEmpresaRespository, EmpresaRepository>();
builder.Services.AddScoped<ITipoDocumentoRespository, TipoDocumentoRepository>();
builder.Services.AddScoped<ICategoriaDeMatriculaRepository, CategoriaDeMatriculaRepository>();
builder.Services.AddScoped<ITipoDeSociedadRepository, TipoDeSociedadRepository>();
builder.Services.AddScoped<ITipoDeOrganizacionRepository, TipoDeOrganizacionRepository>();
builder.Services.AddScoped<IEstadoMatriculaRepository, EstadoMatriculaRepository>();
builder.Services.AddScoped<IActividadEconomicaRepository, ActividadEconomicaRepository>();
builder.Services.AddScoped<CategoriaDeMatriculaService>();
builder.Services.AddScoped<TipoDocumentoService>();
builder.Services.AddScoped<EmpresaService>();
builder.Services.AddScoped<TipoDeSociedadService>();
builder.Services.AddScoped<TipoDeOrganizacionService>();
builder.Services.AddScoped<EstadoMatriculaService>();
builder.Services.AddScoped<ActividadEconomicaService>();
builder.Services.AddLogging(logging =>
{
    logging.ClearProviders();
    logging.AddConsole();
    logging.AddDebug();
});

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

app.UseAuthorization();

app.MapRazorPages();

app.Run();