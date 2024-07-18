namespace GestionDeSeguros.Aplicacion.UseCases.Siniestro;

using GestionDeSeguros.Aplicacion.Interfaces;
using GestionDeSeguros.Aplicacion.Entidades;

public class AgregarSiniestroUseCase : SiniestroUseCase
{
    public AgregarSiniestroUseCase(IRepositorioSiniestro repositorio) : base(repositorio){}

    public void Ejecutar(Siniestro siniestro)
    {
        Repositorio.AgregarSiniestro(siniestro);
    }
}