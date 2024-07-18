namespace GestionDeSeguros.Aplicacion.UseCases.Poliza;

using GestionDeSeguros.Aplicacion.Interfaces;
using GestionDeSeguros.Aplicacion.Entidades;

public class ListarPolizasUseCase : PolizaUseCase
{
    public ListarPolizasUseCase(IRepositorioPoliza repositorio) : base(repositorio){}

    public List<Poliza> Ejecutar()
    {
        return Repositorio.ListarPolizas();
    }
        
}