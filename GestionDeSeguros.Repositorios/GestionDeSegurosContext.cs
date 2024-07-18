namespace GestionDeSeguros.Repositorios;

using GestionDeSeguros.Aplicacion.Entidades;
using Microsoft.EntityFrameworkCore;

public class GestionDeSegurosContext : DbContext
{
    #nullable disable
    public DbSet<Titular> Titulares { get; set; }
    public DbSet<Vehiculo> Vehiculos { get; set; }
    public DbSet<Poliza> Polizas { get; set; }
    public DbSet<Tercero> Terceros { get; set; }
    public DbSet<Siniestro> Siniestros { get; set; }
    #nullable restore

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("data source=GestionDeSeguros.sqlite");
    }
}