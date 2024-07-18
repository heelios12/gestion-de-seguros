namespace GestionDeSeguros.Aplicacion.UseCases.Vehiculo;

using GestionDeSeguros.Aplicacion.Interfaces;

public class EliminarVehiculoUseCase : VehiculoUseCase
{
    public EliminarVehiculoUseCase(IRepositorioVehiculo repositorio) : base(repositorio){}

    public void Ejecutar(int id)
    {
        Repositorio.EliminarVehiculo(id);
    }
}
