namespace GestionDeSeguros.Aplicacion.UseCases.Tercero;

using GestionDeSeguros.Aplicacion.Interfaces;
using GestionDeSeguros.Aplicacion.Entidades;

public class ListarTercerosUseCase : TerceroUseCase
{
    public ListarTercerosUseCase(IRepositorioTercero repositorio) : base(repositorio){}

    public List<Tercero> Ejecutar()
    {
        return Repositorio.ListarTerceros();
    }
}