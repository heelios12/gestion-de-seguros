namespace GestionDeSeguros.Aplicacion.UseCases.Titular;

using GestionDeSeguros.Aplicacion.Interfaces;
using GestionDeSeguros.Aplicacion.Entidades;

public class ObtenerTitularPorDniUseCase : TitularUseCase
{
    public ObtenerTitularPorDniUseCase(IRepositorioTitular repositorio) : base(repositorio){}

    public Titular? Ejecutar(string dni)
    {
        return Repositorio.ObtenerTitularPorDni(dni);
    }
}