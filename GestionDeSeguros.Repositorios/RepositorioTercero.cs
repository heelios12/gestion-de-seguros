namespace GestionDeSeguros.Repositorios;

using GestionDeSeguros.Aplicacion.Entidades;
using GestionDeSeguros.Aplicacion.Interfaces;

public class RepositorioTercero : IRepositorioTercero
{
    public void AgregarTercero(Tercero tercero)
    {
        using (var context = new GestionDeSegurosContext())
        {
            context.Add(tercero);
            context.SaveChanges();
        }
    }
    public void ModificarTercero(Tercero tercero)
    {
        using (var context = new GestionDeSegurosContext())
        {
            context.Terceros.Update(tercero);
            context.SaveChanges();
        }
    }
    public void EliminarTercero(int id)
    {
        using (var context = new GestionDeSegurosContext())
        {
            var terceroBorrar = context.Terceros.SingleOrDefault(t => t.Id == id);
            if (terceroBorrar != null)
            {
                context.Remove(terceroBorrar);
                context.SaveChanges();
            }
        }
    }
    public List<Tercero> ListarTerceros()
    {
        List<Tercero> lista = new List<Tercero>();
        using (var context = new GestionDeSegurosContext())
        {
            lista = context.Terceros.ToList();
        }
        return lista;
    }
    public Tercero? ObtenerTercero(int id)
    {
        Tercero? tercero = null;
        using (var context = new GestionDeSegurosContext())
        {
            tercero = context.Terceros.SingleOrDefault(t => t.Id == id);
        }
        return tercero;
    }
}