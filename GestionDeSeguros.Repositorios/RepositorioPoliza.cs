namespace GestionDeSeguros.Repositorios;

using GestionDeSeguros.Aplicacion.Entidades;
using GestionDeSeguros.Aplicacion.Interfaces;

public class RepositorioPoliza : IRepositorioPoliza
{
    public void AgregarPoliza(Poliza poliza)
    {
        using (var context = new GestionDeSegurosContext())
        {
            context.Add(poliza);
            context.SaveChanges();
        }
    }
    public void ModificarPoliza(Poliza poliza)
    {
        using (var context = new GestionDeSegurosContext())
        {
            context.Polizas.Update(poliza);
            context.SaveChanges();
        }
    }
    public void EliminarPoliza(int id)
    {
        using (var context = new GestionDeSegurosContext())
        {
            var polizaBorrar = context.Polizas.SingleOrDefault(p => p.Id == id);
            if (polizaBorrar != null)
            {
                context.Remove(polizaBorrar);
                context.SaveChanges();
            }
        }
    }
    public List<Poliza> ListarPolizas()
    {
        List<Poliza> lista = new List<Poliza>();
        using (var context = new GestionDeSegurosContext())
        {
            lista = context.Polizas.ToList();
        }
        return lista;
    }
    public Poliza? ObtenerPoliza(int id)
    {
        Poliza? poliza = null;
        using (var context = new GestionDeSegurosContext())
        {
            poliza = context.Polizas.SingleOrDefault(t => t.Id == id);
        }
        return poliza;
    }
}