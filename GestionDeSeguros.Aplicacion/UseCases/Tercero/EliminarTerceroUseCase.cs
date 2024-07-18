namespace GestionDeSeguros.Aplicacion.UseCases.Tercero;

using GestionDeSeguros.Aplicacion.Interfaces;

public class EliminarTerceroUseCase : TerceroUseCase
{
    public EliminarTerceroUseCase(IRepositorioTercero repositorio) : base(repositorio){}

    public void Ejecutar(int id)
    {
        Repositorio.EliminarTercero(id);
    }
}