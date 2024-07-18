namespace GestionDeSeguros.Aplicacion.Interfaces;

using GestionDeSeguros.Aplicacion.Entidades;

public interface IRepositorioTercero
{
    void AgregarTercero(Tercero tercero);
    void ModificarTercero(Tercero tercero);
    void EliminarTercero(int id);
    List<Tercero> ListarTerceros();
    Tercero? ObtenerTercero(int id);
}