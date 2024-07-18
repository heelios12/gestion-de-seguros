namespace GestionDeSeguros.Aplicacion.UseCases.Siniestro;

using GestionDeSeguros.Aplicacion.Interfaces;

public abstract class SiniestroUseCase
{
    protected IRepositorioSiniestro Repositorio { get; private set; }

    public SiniestroUseCase(IRepositorioSiniestro repositorio)
    {
        this.Repositorio = repositorio;
    }
}