namespace GestionDeSeguros.Aplicacion.UseCases.Vehiculo;

using GestionDeSeguros.Aplicacion.Interfaces;
using GestionDeSeguros.Aplicacion.Entidades;

public class ListarVehiculosUseCase : VehiculoUseCase
{
    public ListarVehiculosUseCase(IRepositorioVehiculo repositorio) : base(repositorio){}

    public List<Vehiculo> Ejecutar()
    {
        return Repositorio.ListarVehiculos();
    }
}
