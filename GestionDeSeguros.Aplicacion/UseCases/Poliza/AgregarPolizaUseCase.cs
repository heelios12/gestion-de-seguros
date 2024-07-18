namespace GestionDeSeguros.Aplicacion.UseCases.Poliza;

using GestionDeSeguros.Aplicacion.Interfaces;
using GestionDeSeguros.Aplicacion.Entidades;

public class AgregarPolizaUseCase : PolizaUseCase
{
    public AgregarPolizaUseCase(IRepositorioPoliza repositorio) : base(repositorio){}

    public void Ejecutar(Poliza poliza)
    {
        Repositorio.AgregarPoliza(poliza);
    }
}