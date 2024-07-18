namespace GestionDeSeguros.Aplicacion.UseCases.Titular;

using GestionDeSeguros.Aplicacion.Interfaces;
using GestionDeSeguros.Aplicacion.Entidades;

public class AgregarTitularUseCase : TitularUseCase
{
    public AgregarTitularUseCase(IRepositorioTitular repositorio) : base(repositorio){}

    public void Ejecutar(Titular titular)
    {
        Repositorio.AgregarTitular(titular);
    }
}
