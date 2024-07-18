namespace GestionDeSeguros.Repositorios;

using GestionDeSeguros.Aplicacion.Entidades;
using GestionDeSeguros.Aplicacion.Interfaces;

public class RepositorioTitular : IRepositorioTitular
{
    public void AgregarTitular(Titular titular)
    {
        using (var context = new GestionDeSegurosContext())
        {
            context.Add(titular);
            context.SaveChanges();
        }
    }
    public void ModificarTitular(Titular titular)
    {
        using (var context = new GestionDeSegurosContext())
        {
            context.Titulares.Update(titular);
            context.SaveChanges();
        }
    }
    public void EliminarTitular(int id)
    {
        using (var context = new GestionDeSegurosContext())
        {
            var titularBorrar = context.Titulares.SingleOrDefault(t => t.Id == id);
            if (titularBorrar != null)
            {
                context.Remove(titularBorrar);
                context.SaveChanges();
            }
        }
    }
    public List<Titular> ListarTitulares()
    {
        List<Titular> lista = new List<Titular>();
        using (var context = new GestionDeSegurosContext())
        {
            lista = context.Titulares.ToList();
        }
        return lista;
    }
    public Titular? ObtenerTitular(int id)
    {
        Titular? titular = null;
        using (var context = new GestionDeSegurosContext())
        {
            titular = context.Titulares.SingleOrDefault(t => t.Id == id);
        }
        return titular;
    }
    public Titular? ObtenerTitularPorDni(string dni)
    {
        Titular? titular = null;
        using (var context = new GestionDeSegurosContext())
        {
            titular = context.Titulares.SingleOrDefault(t => t.Dni == dni);
        }
        return titular;
    }
}