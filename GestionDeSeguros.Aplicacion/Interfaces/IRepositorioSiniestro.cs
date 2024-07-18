namespace GestionDeSeguros.Aplicacion.Interfaces;

using GestionDeSeguros.Aplicacion.Entidades;

public interface IRepositorioSiniestro
{
    void AgregarSiniestro(Siniestro siniestro);
    void ModificarSiniestro(Siniestro siniestro);
    void EliminarSiniestro(int id);
    List<Siniestro> ListarSiniestros();
    Siniestro? ObtenerSiniestro(int id);
}