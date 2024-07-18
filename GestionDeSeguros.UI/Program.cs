using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

using GestionDeSeguros.Repositorios;

using GestionDeSeguros.Aplicacion.Interfaces;

using GestionDeSeguros.Aplicacion.UseCases.Poliza;
using GestionDeSeguros.Aplicacion.UseCases.Siniestro;
using GestionDeSeguros.Aplicacion.UseCases.Tercero;
using GestionDeSeguros.Aplicacion.UseCases.Titular;
using GestionDeSeguros.Aplicacion.UseCases.Vehiculo;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddTransient<AgregarPolizaUseCase>();
builder.Services.AddTransient<ModificarPolizaUseCase>();
builder.Services.AddTransient<EliminarPolizaUseCase>();
builder.Services.AddTransient<ListarPolizasUseCase>();
builder.Services.AddTransient<ObtenerPolizaUseCase>();
builder.Services.AddScoped<IRepositorioPoliza, RepositorioPoliza>();

builder.Services.AddTransient<AgregarSiniestroUseCase>();
builder.Services.AddTransient<ModificarSiniestroUseCase>();
builder.Services.AddTransient<EliminarSiniestroUseCase>();
builder.Services.AddTransient<ListarSiniestrosUseCase>();
builder.Services.AddTransient<ObtenerSiniestroUseCase>();
builder.Services.AddScoped<IRepositorioSiniestro, RepositorioSiniestro>();

builder.Services.AddTransient<AgregarTerceroUseCase>();
builder.Services.AddTransient<ModificarTerceroUseCase>();
builder.Services.AddTransient<EliminarTerceroUseCase>();
builder.Services.AddTransient<ListarTercerosUseCase>();
builder.Services.AddTransient<ObtenerTerceroUseCase>();
builder.Services.AddScoped<IRepositorioTercero, RepositorioTercero>();

builder.Services.AddTransient<AgregarTitularUseCase>();
builder.Services.AddTransient<ModificarTitularUseCase>();
builder.Services.AddTransient<EliminarTitularUseCase>();
builder.Services.AddTransient<ListarTitularesUseCase>();
builder.Services.AddTransient<ObtenerTitularUseCase>();
builder.Services.AddTransient<ObtenerTitularPorDniUseCase>();
builder.Services.AddTransient<ListarTitularesConSusVehiculosUseCase>();
builder.Services.AddScoped<IRepositorioTitular, RepositorioTitular>();

builder.Services.AddTransient<AgregarVehiculoUseCase>();
builder.Services.AddTransient<ModificarVehiculoUseCase>();
builder.Services.AddTransient<EliminarVehiculoUseCase>();
builder.Services.AddTransient<ListarVehiculosUseCase>();
builder.Services.AddTransient<ObtenerVehiculoUseCase>();
builder.Services.AddScoped<IRepositorioVehiculo, RepositorioVehiculo>();

using (var context = new GestionDeSegurosContext())
{
    context.Database.EnsureCreated();
}


// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}


app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
