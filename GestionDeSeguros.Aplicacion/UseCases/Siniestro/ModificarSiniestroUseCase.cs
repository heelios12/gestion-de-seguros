namespace GestionDeSeguros.Aplicacion.UseCases.Siniestro;

using GestionDeSeguros.Aplicacion.Interfaces;
using GestionDeSeguros.Aplicacion.Entidades;

public class ModificarSiniestroUseCase : SiniestroUseCase
{
    public ModificarSiniestroUseCase(IRepositorioSiniestro repositorio) : base(repositorio){}

    public void Ejecutar(Siniestro siniestro)
    {
        Repositorio.ModificarSiniestro(siniestro);
    }
}