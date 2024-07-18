namespace GestionDeSeguros.Repositorios;

using GestionDeSeguros.Aplicacion.Entidades;
using GestionDeSeguros.Aplicacion.Interfaces;

public class RepositorioSiniestro : IRepositorioSiniestro
{
    public void AgregarSiniestro(Siniestro siniestro)
    {
        using (var context = new GestionDeSegurosContext())
        {
            context.Add(siniestro);
            context.SaveChanges();
        }
    }
    public void ModificarSiniestro(Siniestro siniestro)
    {
        using (var context = new GestionDeSegurosContext())
        {
            context.Siniestros.Update(siniestro);
            context.SaveChanges();
        }
    }
    public void EliminarSiniestro(int id)
    {
        using (var context = new GestionDeSegurosContext())
        {
            var siniestroBorrar = context.Siniestros.SingleOrDefault(s => s.Id == id);
            if (siniestroBorrar != null)
            {
                context.Remove(siniestroBorrar);
                context.SaveChanges();
            }
        }
    }
    public List<Siniestro> ListarSiniestros()
    {
        List<Siniestro> lista = new List<Siniestro>();
        using (var context = new GestionDeSegurosContext())
        {
            lista = context.Siniestros.ToList();
        }
        return lista;
    }
    public Siniestro? ObtenerSiniestro(int id)
    {
        Siniestro? siniestro = null;
        using (var context = new GestionDeSegurosContext())
        {
            siniestro = context.Siniestros.SingleOrDefault(t => t.Id == id);
        }
        return siniestro;
    }
}