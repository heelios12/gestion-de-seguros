namespace GestionDeSeguros.Aplicacion.UseCases.Tercero;

using GestionDeSeguros.Aplicacion.Interfaces;
using GestionDeSeguros.Aplicacion.Entidades;

public class ModificarTerceroUseCase : TerceroUseCase
{
    public ModificarTerceroUseCase(IRepositorioTercero repositorio) : base(repositorio){}

    public void Ejecutar(Tercero tercero)
    {
        Repositorio.ModificarTercero(tercero);
    }
}