namespace GestionDeSeguros.Aplicacion.UseCases.Vehiculo;

using GestionDeSeguros.Aplicacion.Interfaces;

public abstract class VehiculoUseCase
{
    protected IRepositorioVehiculo Repositorio { get; private set; }

    public VehiculoUseCase(IRepositorioVehiculo repositorio)
    {
        this.Repositorio = repositorio;
    }
}