namespace GestionDeSeguros.Aplicacion.UseCases.Vehiculo;

using GestionDeSeguros.Aplicacion.Interfaces;
using GestionDeSeguros.Aplicacion.Entidades;

public class ObtenerVehiculoUseCase : VehiculoUseCase
{
    public ObtenerVehiculoUseCase(IRepositorioVehiculo repositorio) : base(repositorio){}

    public Vehiculo? Ejecutar(int id)
    {
        return Repositorio.ObtenerVehiculo(id);
    }
}