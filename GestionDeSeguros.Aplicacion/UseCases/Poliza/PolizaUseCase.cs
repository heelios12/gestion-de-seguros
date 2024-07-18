namespace GestionDeSeguros.Aplicacion.UseCases.Poliza;

using GestionDeSeguros.Aplicacion.Interfaces;

public abstract class PolizaUseCase
{
    protected IRepositorioPoliza Repositorio { get; private set; }

    public PolizaUseCase(IRepositorioPoliza repositorio)
    {
        this.Repositorio = repositorio;
    }
}