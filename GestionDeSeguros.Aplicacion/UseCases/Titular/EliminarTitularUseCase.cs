namespace GestionDeSeguros.Aplicacion.UseCases.Titular;

using GestionDeSeguros.Aplicacion.Interfaces;

public class EliminarTitularUseCase : TitularUseCase
{
    public EliminarTitularUseCase(IRepositorioTitular repositorio) : base(repositorio){}

    public void Ejecutar(int id)
    {
        Repositorio.EliminarTitular(id);
    }
}
