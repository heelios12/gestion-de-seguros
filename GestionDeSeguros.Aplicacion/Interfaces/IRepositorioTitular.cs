namespace GestionDeSeguros.Aplicacion.Interfaces;

using GestionDeSeguros.Aplicacion.Entidades;

public interface IRepositorioTitular
{
    void AgregarTitular(Titular titular);
    void ModificarTitular(Titular titular);
    void EliminarTitular(int dni);
    List<Titular> ListarTitulares();
    Titular? ObtenerTitular(int id);
    Titular? ObtenerTitularPorDni(string dni);
}