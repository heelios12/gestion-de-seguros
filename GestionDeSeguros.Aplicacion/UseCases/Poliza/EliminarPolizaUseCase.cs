namespace GestionDeSeguros.Aplicacion.UseCases.Poliza;

using GestionDeSeguros.Aplicacion.Interfaces;

public class EliminarPolizaUseCase : PolizaUseCase
{
    public EliminarPolizaUseCase(IRepositorioPoliza repositorio) : base(repositorio){}

    public void Ejecutar(int id)
    {
        Repositorio.EliminarPoliza(id);
    }
}