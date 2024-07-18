namespace GestionDeSeguros.Aplicacion.UseCases.Titular;

using GestionDeSeguros.Aplicacion.Interfaces;

public abstract class TitularUseCase
{
    protected IRepositorioTitular Repositorio { get; private set; }

    public TitularUseCase(IRepositorioTitular repositorio)
    {
        this.Repositorio = repositorio;
    }
}