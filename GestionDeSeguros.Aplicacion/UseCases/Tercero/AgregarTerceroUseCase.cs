namespace GestionDeSeguros.Aplicacion.UseCases.Tercero;

using GestionDeSeguros.Aplicacion.Interfaces;
using GestionDeSeguros.Aplicacion.Entidades;

public class AgregarTerceroUseCase : TerceroUseCase
{
    public AgregarTerceroUseCase(IRepositorioTercero repositorio) : base(repositorio){}

    public void Ejecutar(Tercero tercero)
    {
        Repositorio.AgregarTercero(tercero);
    }
}