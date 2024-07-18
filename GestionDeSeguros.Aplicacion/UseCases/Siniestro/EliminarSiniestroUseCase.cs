namespace GestionDeSeguros.Aplicacion.UseCases.Siniestro;

using GestionDeSeguros.Aplicacion.Interfaces;

public class EliminarSiniestroUseCase : SiniestroUseCase
{
    public EliminarSiniestroUseCase(IRepositorioSiniestro repositorio) : base(repositorio){}

    public void Ejecutar(int id)
    {
        Repositorio.EliminarSiniestro(id);
    }
}