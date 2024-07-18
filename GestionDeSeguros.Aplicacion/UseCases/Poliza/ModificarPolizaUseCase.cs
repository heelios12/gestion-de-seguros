namespace GestionDeSeguros.Aplicacion.UseCases.Poliza;

using GestionDeSeguros.Aplicacion.Interfaces;
using GestionDeSeguros.Aplicacion.Entidades;

public class ModificarPolizaUseCase : PolizaUseCase
{
    public ModificarPolizaUseCase(IRepositorioPoliza repositorio) : base(repositorio){}

    public void Ejecutar(Poliza poliza)
    {
        Repositorio.ModificarPoliza(poliza);
    }
}