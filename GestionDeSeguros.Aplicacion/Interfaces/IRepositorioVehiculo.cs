namespace GestionDeSeguros.Aplicacion.Interfaces;

using GestionDeSeguros.Aplicacion.Entidades;

public interface IRepositorioVehiculo
{
    void AgregarVehiculo(Vehiculo vehiculo);
    void ModificarVehiculo(Vehiculo vehiculo);
    void EliminarVehiculo(int id);
    List<Vehiculo> ListarVehiculos();
    Vehiculo? ObtenerVehiculo(int id);
    List<Vehiculo> ObtenerVehiculosDeUnTitular(int titularId);
}