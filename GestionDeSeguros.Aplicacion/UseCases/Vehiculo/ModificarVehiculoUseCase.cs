namespace GestionDeSeguros.Aplicacion.UseCases.Vehiculo;

using GestionDeSeguros.Aplicacion.Interfaces;
using GestionDeSeguros.Aplicacion.Entidades;

public class ModificarVehiculoUseCase : VehiculoUseCase
{
    public ModificarVehiculoUseCase(IRepositorioVehiculo repositorio) : base(repositorio){}
    
    public void Ejecutar(Vehiculo vehiculo)
    {
        Repositorio.ModificarVehiculo(vehiculo);
    }
}