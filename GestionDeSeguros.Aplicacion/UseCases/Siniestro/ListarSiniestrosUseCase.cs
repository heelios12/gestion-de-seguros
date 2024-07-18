namespace GestionDeSeguros.Aplicacion.UseCases.Siniestro;

using GestionDeSeguros.Aplicacion.Interfaces;
using GestionDeSeguros.Aplicacion.Entidades;

public class ListarSiniestrosUseCase : SiniestroUseCase
{
    public ListarSiniestrosUseCase(IRepositorioSiniestro repositorio) : base(repositorio){}

    public List<Siniestro> Ejecutar()
    {
        return Repositorio.ListarSiniestros();
    }
}