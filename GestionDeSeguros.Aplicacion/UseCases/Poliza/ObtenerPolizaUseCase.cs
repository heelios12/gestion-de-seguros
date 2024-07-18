namespace GestionDeSeguros.Aplicacion.UseCases.Poliza;

using GestionDeSeguros.Aplicacion.Interfaces;
using GestionDeSeguros.Aplicacion.Entidades;

public class ObtenerPolizaUseCase : PolizaUseCase
{
    public ObtenerPolizaUseCase(IRepositorioPoliza repositorio) : base(repositorio){}

    public Poliza? Ejecutar(int id)
    {
        return Repositorio.ObtenerPoliza(id);
    }
}