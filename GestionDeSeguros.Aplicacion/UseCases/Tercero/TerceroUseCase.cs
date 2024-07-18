namespace GestionDeSeguros.Aplicacion.UseCases.Tercero;

using GestionDeSeguros.Aplicacion.Interfaces;

public abstract class TerceroUseCase
{
    protected IRepositorioTercero Repositorio { get; private set; }

    public TerceroUseCase(IRepositorioTercero repositorio)
    {
        this.Repositorio = repositorio;
    }
}