namespace GestionDeSeguros.Aplicacion.UseCases.Tercero;

using GestionDeSeguros.Aplicacion.Interfaces;
using GestionDeSeguros.Aplicacion.Entidades;

public class ObtenerTerceroUseCase : TerceroUseCase
{
    public ObtenerTerceroUseCase(IRepositorioTercero repositorio) : base(repositorio){}

    public Tercero? Ejecutar(int id)
    {
        return Repositorio.ObtenerTercero(id);
    }
}