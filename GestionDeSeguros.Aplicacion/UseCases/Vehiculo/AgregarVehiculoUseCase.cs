namespace GestionDeSeguros.Aplicacion.UseCases.Vehiculo;

using GestionDeSeguros.Aplicacion.Interfaces;
using GestionDeSeguros.Aplicacion.Entidades;

public class AgregarVehiculoUseCase : VehiculoUseCase
{
    public AgregarVehiculoUseCase(IRepositorioVehiculo repositorio) : base(repositorio){}

    public void Ejecutar(Vehiculo vehiculo)
    {
        Repositorio.AgregarVehiculo(vehiculo);
    }
}
