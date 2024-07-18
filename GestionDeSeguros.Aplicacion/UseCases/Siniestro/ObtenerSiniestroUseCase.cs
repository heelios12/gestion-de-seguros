namespace GestionDeSeguros.Aplicacion.UseCases.Siniestro;

using GestionDeSeguros.Aplicacion.Interfaces;
using GestionDeSeguros.Aplicacion.Entidades;

public class ObtenerSiniestroUseCase : SiniestroUseCase
{
    public ObtenerSiniestroUseCase(IRepositorioSiniestro repositorio) : base(repositorio){}

    public Siniestro? Ejecutar(int id)
    {
        return Repositorio.ObtenerSiniestro(id);
    }
}