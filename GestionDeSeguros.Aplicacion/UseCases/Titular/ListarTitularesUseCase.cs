namespace GestionDeSeguros.Aplicacion.UseCases.Titular;

using GestionDeSeguros.Aplicacion.Interfaces;
using GestionDeSeguros.Aplicacion.Entidades;

public class ListarTitularesUseCase : TitularUseCase
{
    public ListarTitularesUseCase(IRepositorioTitular repositorio) : base(repositorio){}

    public List<Titular> Ejecutar()
    {
        return Repositorio.ListarTitulares();
    }
}
