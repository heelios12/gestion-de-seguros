namespace GestionDeSeguros.Aplicacion.Interfaces;

using GestionDeSeguros.Aplicacion.Entidades;

public interface IRepositorioPoliza
{
    void AgregarPoliza(Poliza poliza);
    void ModificarPoliza(Poliza poliza);
    void EliminarPoliza(int id);
    List<Poliza> ListarPolizas();
    Poliza? ObtenerPoliza(int id);
}