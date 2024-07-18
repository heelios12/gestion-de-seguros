namespace GestionDeSeguros.Aplicacion.Entidades;

public class Titular : Persona
{
    public int Id {get; set;}
    public string Direccion {get; set;} = "";
    public string CorreoElectronico {get; set;} = "";

    public List<Vehiculo> Vehiculos { get; set; } = new List<Vehiculo>();

    public Titular(string nombre, string apellido, string dni) : base(nombre, apellido, dni){}

    public override string ToString()
    {
        return $"Id: {Id},  {base.ToString()}, Direccion: {Direccion}, Correo Electronico: {CorreoElectronico}";
    }
}
