namespace GestionDeSeguros.Aplicacion.UseCases.Titular;

using GestionDeSeguros.Aplicacion.Interfaces;
using GestionDeSeguros.Aplicacion.Entidades;

public class ListarTitularesConSusVehiculosUseCase : TitularUseCase
{
    private readonly IRepositorioVehiculo _repositorioVehiculo;
    public ListarTitularesConSusVehiculosUseCase(IRepositorioTitular repositorioTitular, IRepositorioVehiculo repositorioVehiculo) : base(repositorioTitular)
    {
        _repositorioVehiculo = repositorioVehiculo;
    }

    public List<Titular> Ejecutar()
    {
        List<Titular> titulares  = Repositorio.ListarTitulares();
        foreach (var titular in titulares)
        {
            titular.Vehiculos = _repositorioVehiculo.ObtenerVehiculosDeUnTitular(titular.Id);
        }
        return titulares;
    }
}