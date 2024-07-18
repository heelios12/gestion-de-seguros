namespace GestionDeSeguros.Repositorios;

using GestionDeSeguros.Aplicacion.Entidades;
using GestionDeSeguros.Aplicacion.Interfaces;

public class RepositorioVehiculo : IRepositorioVehiculo
{
    public void AgregarVehiculo(Vehiculo vehiculo)
    {
        using (var context = new GestionDeSegurosContext())
        {
            context.Add(vehiculo);
            context.SaveChanges();
        }
    }
    public void ModificarVehiculo(Vehiculo vehiculo)
    {
        using (var context = new GestionDeSegurosContext())
        {
            context.Vehiculos.Update(vehiculo);
            context.SaveChanges();
        }
    }
    public void EliminarVehiculo(int id)
    {
        using (var context = new GestionDeSegurosContext())
        {
            var vehiculoBorrar = context.Vehiculos.SingleOrDefault(v => v.Id == id);
            if (vehiculoBorrar != null)
            {
                context.Remove(vehiculoBorrar);
                context.SaveChanges();
            }
        }
    }
    public List<Vehiculo> ListarVehiculos()
    {
        List<Vehiculo> lista = new List<Vehiculo>();
        using (var context = new GestionDeSegurosContext())
        {
            lista = context.Vehiculos.ToList();
        }
        return lista;
    }
    public Vehiculo? ObtenerVehiculo(int id)
    {
        Vehiculo? vehiculo = null;
        using (var context = new GestionDeSegurosContext())
        {
            vehiculo = context.Vehiculos.SingleOrDefault(t => t.Id == id);
        }
        return vehiculo;
    }
    public List<Vehiculo> ObtenerVehiculosDeUnTitular(int titularId)
    {
        List<Vehiculo> lista = new List<Vehiculo>();
        using (var context = new GestionDeSegurosContext())
        {
            lista = context.Vehiculos.Where(v => v.TitularId == titularId).ToList();
        }
        return lista;
    }
}