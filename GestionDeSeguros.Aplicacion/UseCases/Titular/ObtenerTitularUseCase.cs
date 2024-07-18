namespace GestionDeSeguros.Aplicacion.UseCases.Titular;

using GestionDeSeguros.Aplicacion.Interfaces;
using GestionDeSeguros.Aplicacion.Entidades;

public class ObtenerTitularUseCase : TitularUseCase
{
    public ObtenerTitularUseCase(IRepositorioTitular repositorio) : base(repositorio){}

    public Titular? Ejecutar(int id)
    {
        return Repositorio.ObtenerTitular(id);
    }
}
